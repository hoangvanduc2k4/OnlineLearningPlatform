using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Extensions;
namespace OnlineLearningPlatform.Areas.Mentee.Pages.WishList
{
    public class IndexModel : PageModel
    {
        private readonly IWishlistRepository _wishlistRepository;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IHubContext<CRUDHub> _hub;
        public IndexModel(
            IWishlistRepository wishlistRepository,
            UserManager<User> userManager,
            IMapper mapper, IHubContext<CRUDHub> hub)
        {
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
            _mapper = mapper;
            _hub = hub;
        }

        public IPagedList<CourseViewModel> WishlistCourses { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public async Task<IActionResult> OnGetAsync(int pageNumber = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Challenge();
            }

            int pageSize = 6;

            var wishlistItems = await _wishlistRepository.GetByUserIdAsync(user.Id);
            var courses = wishlistItems.Select(w => w.Course).ToList();

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                var lowerSearch = SearchTerm.ToLower();
                courses = courses.Where(c =>
                    (c.CourseName != null && c.CourseName.ToLower().Contains(lowerSearch)) ||
                    (c.Description != null && c.Description.ToLower().Contains(lowerSearch))
                ).ToList();
            }

            var vms = _mapper.Map<List<CourseViewModel>>(courses);

            WishlistCourses = vms.ToPagedList(pageNumber, pageSize);

            return Page();
        }

        public async Task<IActionResult> OnPostRemoveAsync(long courseId, int pageNumber = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Challenge();
            }

            var wishlistItem = await _wishlistRepository.GetAsync(user.Id, courseId);

            if (wishlistItem != null)
            {
                await _wishlistRepository.RemoveAsync(wishlistItem);
                TempData["SuccessMessage"] = "Course removed from wishlist.";
            }
            else
            {
                TempData["ErrorMessage"] = "Course not found in wishlist.";
            }
            await _hub.Clients.All.SendAsync("LoadWishList");
            return RedirectToPage(new { SearchTerm = SearchTerm, pageNumber = pageNumber });
        }
    }
}