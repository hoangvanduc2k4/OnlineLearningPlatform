using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IVnPayService _vnPayService;
        private readonly UserManager<User> _userManager;
        private readonly ITransactionService _transactionService;
        private readonly ICourseEnrollmentService _courseEnrollmentService;
        private readonly ICategoryService _categoryService;
        private readonly ILevelService _levelService;
        private readonly IWishlistService _wishlistService;

        public CoursesController(ICourseService courseService, IVnPayService vnPayService, UserManager<User> userManager, ITransactionService transactionService, ICourseEnrollmentService courseEnrollmentService, ICategoryService categoryService, ILevelService levelService, IWishlistService wishlistService)
        {
            _courseService = courseService;
            _vnPayService = vnPayService;
            _userManager = userManager;
            _transactionService = transactionService;
            _courseEnrollmentService = courseEnrollmentService;
            _categoryService = categoryService;
            _levelService = levelService;
            _wishlistService = wishlistService;
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
            ViewBag.AllCategories = await _categoryService.GetAllActiveCategoryAysnc();
            ViewBag.AllLevels = await _levelService.GetAllActiveLevelAysnc();
            return View(paged);
        }
        public async Task<IActionResult> Details(long id)
        {
            var vm = await _courseService.GetCourseDetailsAsync(id);
            if (vm == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                vm.IsInWishlist = await _wishlistService.IsInWishlistAsync(user.Id, id);
            }
            else
            {
                vm.IsInWishlist = false;
            }

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
            var priceAfterDiscount = course.Price - (course.Price * (course.Discount ?? 0) / 100);

            var vnPayModel = new VnPaymentRequestModel
            {
                Amount = (double)priceAfterDiscount,
                Description = $"Pay for course: {course.CourseName} (after {(course.Discount ?? 0)}% discount)",
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
