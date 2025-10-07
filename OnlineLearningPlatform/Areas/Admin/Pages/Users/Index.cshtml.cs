using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;
using System.Collections.Generic;
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
        public string FilterType { get; set; } = "all";

        public async Task OnGetAsync(int? pageNumber, int? pageSize, string searchTerm, string filterType)
        {
            PageSize = pageSize ?? 10;
            SearchTerm = searchTerm;
            FilterType = filterType ?? "all";

            IEnumerable<User> users;

            switch (FilterType)
            {
                case "active":
                    users = await _userService.GetActiveUsersAsync(SearchTerm);
                    break;
                case "inactive":
                    users = await _userService.GetInactiveUsersAsync(SearchTerm);
                    break;
                case "deleted":
                    users = await _userService.GetDeletedUsersAsync(SearchTerm);
                    break;
                default:
                    users = await _userService.GetAllUsersAsync(SearchTerm);
                    break;
            }

            int page = pageNumber ?? 1;
            PagedUsers = users is not null
                ? users.OrderByDescending(u => u.CreatedAt).ToPagedList(page, PageSize)
                : new List<User>().ToPagedList(page, PageSize);
        }

        public async Task OnPostDeleteAsync(string id, int? pageNumber, int? pageSize, string searchTerm, string filterType)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user != null)
            {
                await _userService.DeleteUserAsync(id);
                TempData["SuccessMessage"] = "Deleted successfully.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType);
        }
    }
}