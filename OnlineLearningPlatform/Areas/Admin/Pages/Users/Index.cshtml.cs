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
        private readonly IRoleService _roleService;

        public IndexModel(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public IPagedList<User> PagedUsers { get; set; }
        public int PageSize { get; set; } = 10;
        public string SearchTerm { get; set; }
        public string FilterType { get; set; } = "active";
        public string SelectedRole { get; set; } = "";
        public List<string> AvailableRoles { get; set; } = new();
        public Dictionary<string, List<string>> UserRoles { get; set; } = new();

        public async Task OnGetAsync(int? pageNumber, int? pageSize, string searchTerm, string filterType, string role)
        {
            PageSize = pageSize ?? 10;
            SearchTerm = searchTerm;
            FilterType = filterType ?? "active";
            SelectedRole = role ?? "";

            // Lấy danh sách role
            AvailableRoles = (await _roleService.GetAllRolesAsync()).Select(r => r.Name).ToList();

            IEnumerable<User> users = FilterType switch
            {
                "inactive" => await _userService.GetInactiveUsersAsync(SearchTerm),
                "deleted" => await _userService.GetDeletedUsersAsync(SearchTerm),
                _ => await _userService.GetActiveUsersAsync(SearchTerm),
            };

            // Lọc theo role nếu có chọn
            if (!string.IsNullOrWhiteSpace(SelectedRole))
            {
                var userIdsInRole = await _roleService.GetUserIdsInRoleAsync(SelectedRole);
                users = users.Where(u => userIdsInRole.Contains(u.Id));
            }

            // Lấy role của từng user để hiển thị
            UserRoles = new Dictionary<string, List<string>>();
            foreach (var user in users)
            {
                var roles = await _roleService.GetUserRolesAsync(user.Id);
                UserRoles[user.Id] = roles.ToList();
            }

            int page = pageNumber ?? 1;
            PagedUsers = users.OrderByDescending(u => u.CreatedAt).ToPagedList(page, PageSize);
        }

        public async Task OnPostDeleteAsync(string id, int? pageNumber, int? pageSize, string searchTerm, string filterType, string role)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user != null)
            {
                await _userService.DeleteUserAsync(id);
                TempData["SuccessMessage"] = "Deleted successfully.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, role);
        }

        public async Task OnPostRestoreAsync(string id, int? pageNumber, int? pageSize, string searchTerm, string filterType, string role)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user != null)
            {
                user.IsActived = true;
                user.IsDeleted = false;
                await _userService.UpdateUserAsync(user);
                TempData["SuccessMessage"] = "User restored successfully.";
            }
            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, role);
        }

        public async Task OnPostDeactivateAsync(string id, int? pageNumber, int? pageSize, string searchTerm, string filterType, string role)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user != null)
            {
                user.IsActived = false;
                await _userService.UpdateUserAsync(user);
                TempData["SuccessMessage"] = "User deactivated successfully.";
            }
            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, role);
        }
    }
}