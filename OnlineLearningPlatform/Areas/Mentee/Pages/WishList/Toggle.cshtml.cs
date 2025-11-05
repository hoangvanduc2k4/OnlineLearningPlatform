using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
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
        private readonly IHubContext<CRUDHub> _hub;

        public ToggleModel(IWishlistService wishlistService, UserManager<User> userManager, IHubContext<CRUDHub> hub)
        {
            _wishlistService = wishlistService;
            _userManager = userManager;
            _hub = hub;
        }
        public async Task<IActionResult> OnPostAsync(long courseId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            bool isNowInWishlist = await _wishlistService.ToggleWishlistItemAsync(user.Id, courseId);
            await _hub.Clients.All.SendAsync("LoadWishList");
            return new JsonResult(new { isInWishlist = isNowInWishlist });
        }
    }
}