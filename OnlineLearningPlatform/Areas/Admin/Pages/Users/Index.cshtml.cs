using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Users
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public IPagedList<User> PagedUsers { get; set; }
        public int PageSize { get; set; } = 10;
        public string SearchTerm { get; set; }

        public async Task OnGetAsync(int? pageNumber, int? pageSize, string searchTerm)
        {
            PageSize = pageSize ?? 10;
            SearchTerm = searchTerm;

            var allUsers = await _userService.GetAllUsersAsync();

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                allUsers = allUsers.Where(u =>
                    (u.Email != null && u.Email.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase)) ||
                    (u.FullName != null && u.FullName.Contains(SearchTerm, System.StringComparison.OrdinalIgnoreCase))
                );
            }

            int page = pageNumber ?? 1;
            PagedUsers = allUsers.OrderByDescending(u => u.CreatedAt).ToPagedList(page, PageSize);
        }

        public async Task OnPostDeleteAsync(string id, int? pageNumber, int? pageSize, string searchTerm)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user != null)
            {
                await _userService.DeleteUserAsync(id);
                TempData["SuccessMessage"] = "Deleted successfully.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm);
        }
    }
}