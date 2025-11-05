using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using System.Security.Claims;

namespace OnlineLearningPlatform.Areas.Mentor.Controllers
{
    [Area("Mentor")]
    [Authorize(Roles = "Mentor")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILevelRepository _levelRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHubContext<CRUDHub> _hub;
        public CourseController(
        ICourseService courseService,
        ICategoryRepository categoryRepository,
        ILevelRepository levelRepository,
        IWebHostEnvironment webHostEnvironment,
        IHubContext<CRUDHub> hub)
        {
            _courseService = courseService;
            _categoryRepository = categoryRepository;
            _levelRepository = levelRepository;
            _webHostEnvironment = webHostEnvironment;
            _hub = hub;
        }

        // GET: /Mentor/Course
        public async Task<IActionResult> Index()
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (mentorId == null) return Unauthorized();

            var courses = await _courseService.GetCoursesForMentorAsync(mentorId);
            return View(courses);
        }

        // GET: /Mentor/Course/Create
        public async Task<IActionResult> Create()
        {
            //  dropdownlist (Levels, Categories) 
            var viewModel = new CourseCreateViewModel();
            await PopulateFormOptions(viewModel);
            return View(viewModel);
        }

        // POST: /Mentor/Course/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseCreateViewModel viewModel)
        {
            if (viewModel.AllCategories != null)
            {
                viewModel.SelectedCategoryIds = viewModel.AllCategories
                                                    .Where(c => c.IsSelected)
                                                    .Select(c => c.Id)
                                                    .ToList();
            }
            if (viewModel.SelectedCategoryIds.Count == 0)
            {
                ModelState.AddModelError(nameof(viewModel.AllCategories), "You must select at least one category.");
            }

            string? finalImageUrl = null;
            if (viewModel.ImageOption == "file")
            {
                if (viewModel.CoverImageFile != null)
                {
                    finalImageUrl = await SaveImageAsync(viewModel.CoverImageFile);
                }
            }
            else // ImageOption == "url"
            {
                if (!string.IsNullOrEmpty(viewModel.CoverImageUrl))
                {
                    finalImageUrl = viewModel.CoverImageUrl;
                }
            }

            if (ModelState.IsValid)
            {
                var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(mentorId)) return Unauthorized();

                var newCourse = new Course
                {
                    CourseName = viewModel.CourseName,
                    Description = viewModel.Description,
                    Price = viewModel.Price,
                    Discount = viewModel.Discount,
                    LevelId = viewModel.LevelId
                };

                await _courseService.CreateCourseAsync(newCourse, mentorId, viewModel.SelectedCategoryIds, finalImageUrl);

                return RedirectToAction(nameof(Index));
            }

            await PopulateFormOptions(viewModel);
            await _hub.Clients.All.SendAsync("LoadCourses");

            return View(viewModel);
        }

        private async Task PopulateFormOptions(CourseCreateViewModel viewModel)
        {
            var levels = await _levelRepository.GetAllActiveAsync();
            var categories = await _categoryRepository.GetAllActiveAsync();

            viewModel.Levels = new SelectList(levels, "LevelId", "LevelName", viewModel.LevelId);
            viewModel.AllCategories = categories.Select(c => new CategoryViewModel
            {
                Id = c.CategoryId,
                Name = c.CategoryName,
                IsSelected = viewModel.SelectedCategoryIds.Contains(c.CategoryId)
            }).ToList();
        }

        // GET: /Mentor/Course/Edit/5
        public async Task<IActionResult> Edit(long id)
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(mentorId)) return Unauthorized();

            var course = await _courseService.GetCourseForEditAsync(id, mentorId);

            if (course == null)
            {
                return NotFound();
            }

            if (course.Status != CourseStatus.Draft && course.Status != CourseStatus.Rejected && course.Status != CourseStatus.Approved)
            {
                return RedirectToAction(nameof(Index));
            }


            var viewModel = new CourseEditViewModel
            {
                CourseId = course.CourseId,
                CourseName = course.CourseName,
                Description = course.Description,
                StudyTime = course.StudyTime,
                Price = course.Price,
                Discount = course.Discount,
                LevelId = course.LevelId,
                SelectedCategoryIds = course.CourseCategories.Select(cc => cc.CategoryId).ToList(),
                ExistingCoverImageUrl = course.CourseImageUrls.FirstOrDefault()?.Url,
                CurrentStatus = course.Status
            };

            await PopulateFormOptions(viewModel);
            return View(viewModel);
        }

        // POST: /Mentor/Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, CourseEditViewModel viewModel, string action)
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id != viewModel.CourseId) return BadRequest();

            if (viewModel.AllCategories != null)
            {
                viewModel.SelectedCategoryIds = viewModel.AllCategories
                                                    .Where(c => c.IsSelected)
                                                    .Select(c => c.Id)
                                                    .ToList();
            }
            if (viewModel.SelectedCategoryIds.Count == 0)
            {
                ModelState.AddModelError(nameof(viewModel.AllCategories), "You must select at least one category.");
            }

            if (ModelState.IsValid)
            {
                CourseStatus newStatus;
                if (action == "submit_review")
                {
                    newStatus = CourseStatus.Pending;
                }
                else
                {
                    newStatus = CourseStatus.Draft;
                }

                string? finalImageUrl = viewModel.ExistingCoverImageUrl;
                if (viewModel.ImageOption == "file" && viewModel.NewCoverImage != null)
                {
                    finalImageUrl = await SaveImageAsync(viewModel.NewCoverImage);
                }
                else if (viewModel.ImageOption == "url" && !string.IsNullOrEmpty(viewModel.CoverImageUrl))
                {
                    finalImageUrl = viewModel.CoverImageUrl;
                }

                var courseToUpdate = new Course
                {
                    CourseId = viewModel.CourseId,
                    CourseName = viewModel.CourseName,
                    Description = viewModel.Description,
                    StudyTime = viewModel.StudyTime,
                    Price = viewModel.Price,
                    Discount = viewModel.Discount,
                    LevelId = viewModel.LevelId
                };

                await _courseService.UpdateCourseAsync(courseToUpdate, viewModel.SelectedCategoryIds, finalImageUrl, newStatus, mentorId);

                if (newStatus == CourseStatus.Pending)
                    TempData["SuccessMessage"] = "Course submitted for review successfully!";
                else
                    TempData["SuccessMessage"] = "Course saved as draft successfully!";
                await _hub.Clients.All.SendAsync("LoadCourses");
                return RedirectToAction(nameof(Index));
            }

            await PopulateFormOptions(viewModel);
            return View(viewModel);
        }

        private async Task PopulateFormOptions(CourseEditViewModel viewModel)
        {
            var levels = await _levelRepository.GetAllActiveAsync();
            var categories = await _categoryRepository.GetAllActiveAsync();

            viewModel.Levels = new SelectList(levels, "LevelId", "LevelName", viewModel.LevelId);
            viewModel.AllCategories = categories.Select(c => new CategoryViewModel
            {
                Id = c.CategoryId,
                Name = c.CategoryName,
                IsSelected = viewModel.SelectedCategoryIds.Contains(c.CategoryId)
            }).ToList();
        }
        private async Task<string?> SaveImageAsync(IFormFile? imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                return null;
            }

            var webRootPath = _webHostEnvironment.WebRootPath;
            var uploadPath = Path.Combine(webRootPath, "images", "courses");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
            var filePath = Path.Combine(uploadPath, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            return "/images/courses/" + uniqueFileName;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(long id)
        {
            var mentorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(mentorId))
            {
                return RedirectToAction("Index", "Home");
            }

            var success = await _courseService.DeleteCourseAsync(id, mentorId);

            if (success)
            {
                TempData["SuccessMessage"] = "Course was deleted successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Error: Course not found or you don't have permission.";
            }
            await _hub.Clients.All.SendAsync("LoadCourses");
            return RedirectToAction(nameof(Index));
        }
    }
}
