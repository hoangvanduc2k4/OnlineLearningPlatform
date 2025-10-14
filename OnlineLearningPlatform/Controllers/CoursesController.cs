using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly OnlineLearningDBContext _context;

        public CoursesController(ICourseService courseService, OnlineLearningDBContext context)
        {
            _courseService = courseService;
            _context = context;
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

            ViewBag.AllCategories = await _context.Categories
                .Select(c => new { Id = c.CategoryId, Name = c.CategoryName }) 
                .OrderBy(x => x.Name)
                .ToListAsync();

            ViewBag.AllLevels = await _context.Levels.OrderBy(l => l.LevelName).ToListAsync();

            return View(paged);
        }



        public async Task<IActionResult> Details(long id)
        {
            var vm = await _courseService.GetCourseDetailsAsync(id);
            if (vm == null) return NotFound();
            return View(vm);
        }
    }
}
