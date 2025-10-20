using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly OnlineLearningDBContext _context;
        private readonly IVnPayService _vnPayService;
        private readonly UserManager<User> _userManager;
        private readonly ITransactionService _transactionService;
        private readonly ICategoryService _categoryService;
        private readonly ILevelService _levelService;

        public CoursesController(ICourseService courseService, IVnPayService vnPayService, UserManager<User> userManager, ITransactionService transactionService, ICategoryService categoryService, ILevelService levelService)
        {
            _courseService = courseService;
            _vnPayService = vnPayService;
            _userManager = userManager;
            _transactionService = transactionService;
            _categoryService = categoryService;
            _levelService = levelService;

        }

        public async Task<IActionResult> Index(
           int pageNumber = 1,
           int pageSize = 6,
           string? searchTerm = null,
           string[]? categories = null,
           long[]? levels = null,
           string? priceRange = null,
           string? studyTimeRange = null,
           string? sortBy = null)
        {
            var categoryList = categories?.ToList();
            var levelList = levels?.ToList();

            var paged = await _courseService.GetCoursesPagedAsync(
                pageNumber, pageSize, searchTerm, categoryList, levelList, priceRange, studyTimeRange, sortBy);

            ViewBag.SearchTerm = searchTerm;
            ViewBag.PageSize = pageSize;
            ViewBag.SortBy = sortBy;
            ViewBag.SelectedCategories = categoryList ?? new List<string>();
            ViewBag.SelectedLevels = levelList ?? new List<long>();
            ViewBag.PriceRange = priceRange;
            ViewBag.StudyTimeRange = studyTimeRange;

            ViewBag.AllCategories = await _categoryService.GetAllCategoryAysnc();

            ViewBag.AllLevels = await _levelService.GetAllLevelAysnc();

            return View(paged);
        }



        public async Task<IActionResult> Details(long id)
        {
            var vm = await _courseService.GetCourseDetailsAsync(id);
            if (vm == null) return NotFound();
            return View(vm);
        }


        [HttpPost]
        public async Task<IActionResult> Checkout(long courseId)
        {
            var userId = _userManager.GetUserId(User);

            var course = await _courseService.GetCourseByIdAsync(courseId);
            if (course == null)
            {
                return NotFound("Not found!");
            }

            var transaction = new TransactionHistory
            {
                UserId = userId,
                CourseId = courseId,
                Amount = course.Price,
                Status = TransactionStatus.Pending,
                Description = "Waiting for checkout",
                DateCreated = DateTime.Now
            };

            await _transactionService.AddTransactionAsync(transaction);

            var vnPayModel = new VnPaymentRequestModel
            {
                Amount = (double)course.Price,
                Description = $"Pay for course: {course.CourseName}",
                OrderId = (int)transaction.TransactionId
            };

            var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, vnPayModel);
            return Redirect(paymentUrl);
        }

    }
}
