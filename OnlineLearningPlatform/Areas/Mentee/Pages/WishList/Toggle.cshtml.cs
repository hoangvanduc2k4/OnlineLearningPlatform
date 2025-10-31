using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentee.Pages.WishList
{
    [Authorize]
    [Area("Mentee")]
    public class ToggleModel : PageModel
    {
        private readonly IWishlistService _wishlistService;
        private readonly UserManager<User> _userManager;

        public ToggleModel(IWishlistService wishlistService, UserManager<User> userManager)
        {
            _wishlistService = wishlistService;
            _userManager = userManager;
        }
        public async Task<IActionResult> OnPostAsync(long courseId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            bool isNowInWishlist = await _wishlistService.ToggleWishlistItemAsync(user.Id, courseId);

            return new JsonResult(new { isInWishlist = isNowInWishlist });
        }
    }
}