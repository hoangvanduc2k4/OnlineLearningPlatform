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
        private readonly ICourseEnrollmentService _courseEnrollmentService;
        public CoursesController(ICourseService courseService, OnlineLearningDBContext context, IVnPayService vnPayService, UserManager<User> userManager, ITransactionService transactionService, ICourseEnrollmentService courseEnrollmentService)
        {
            _courseService = courseService;
            _context = context;
            _vnPayService = vnPayService;
            _userManager = userManager;
            _transactionService = transactionService;
            _courseEnrollmentService = courseEnrollmentService;
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


        [HttpPost]
        public async Task<IActionResult> Checkout(long courseId)
        {
            if (TempData["IsProcessingCheckout"] != null && (bool)TempData["IsProcessingCheckout"] == true)
            {
                TempData["Error"] = "Payment request is being processed. Please wait.";
                return RedirectToAction("Details", new { id = courseId });
            }
            TempData["IsProcessingCheckout"] = true;

            var userId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(userId))
            {
                TempData.Remove("IsProcessingCheckout");
                return Challenge();
            }
            var isEnrolled = await _courseEnrollmentService.CheckCourseEnrollment(userId, courseId);
            if (isEnrolled)
            {
                TempData.Remove("IsProcessingCheckout");
                TempData["Error"] = "You have already purchased this course";
                return RedirectToAction("Details", new { id = courseId });
            }
            var course = await _courseService.GetCourseByIdAsync(courseId);
            if (course == null)
            {
                TempData.Remove("IsProcessingCheckout");
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

            var addResult = await _transactionService.AddTransactionAsync(transaction);

            if (!addResult)
            {
                TempData.Remove("IsProcessingCheckout");
                TempData["Error"] = "Transaction could not be created. Please try again.";
                return RedirectToAction("Details", new { id = courseId });
            }
            Console.WriteLine($"[DEBUG] Transaction created with ID: {transaction.TransactionId}");
            var priceAfterDiscount = course.Price - (course.Price * (course.Discount ?? 0) / 100); // Calculate final price

            var vnPayModel = new VnPaymentRequestModel
            {
                Amount = (double)priceAfterDiscount,
                Description = $"Pay for course: {course.CourseName} (after {(course.Discount ?? 0)}% discount)", // Updated description
                OrderId = transaction.TransactionId
            };


            TempData.Remove("IsProcessingCheckout");
            var paymentUrl = _vnPayService.CreatePaymentUrl(HttpContext, vnPayModel);

            Console.WriteLine($"[DEBUG] Redirecting to VNPay URL: {paymentUrl}");

            Console.WriteLine($"[DEBUG] vnp_TxnRef sent: {transaction.TransactionId}");
            return Redirect(paymentUrl);
        }

    }
}
