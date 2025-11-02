using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Extensions;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<IActionResult> OnPostExportExcelAsync(List<string> statuses)
        {
            var users = await _userService.GetAllUsersAsync(""); // Adjust to your service
            var filtered = users.Where(u =>
                (statuses.Contains("active") && u.IsActived && !u.IsDeleted) ||
                (statuses.Contains("inactive") && !u.IsActived && !u.IsDeleted) ||
                (statuses.Contains("deleted") && u.IsDeleted)
            ).ToList();

            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Users");
            worksheet.Cell(1, 1).Value = "Id";
            worksheet.Cell(1, 2).Value = "Email";
            worksheet.Cell(1, 3).Value = "Full Name";
            worksheet.Cell(1, 4).Value = "DOB";
            worksheet.Cell(1, 5).Value = "Phone";
            worksheet.Cell(1, 6).Value = "Gender";
            worksheet.Cell(1, 7).Value = "IsActived";
            worksheet.Cell(1, 8).Value = "IsDeleted";
            worksheet.Cell(1, 9).Value = "CreatedAt";
            worksheet.Cell(1, 10).Value = "UpdatedAt";
            worksheet.Cell(1, 11).Value = "DeletedAt";

            for (int i = 0; i < filtered.Count; i++)
            {
                var u = filtered[i];
                worksheet.Cell(i + 2, 1).Value = u.Id;
                worksheet.Cell(i + 2, 2).Value = u.Email;
                worksheet.Cell(i + 2, 3).Value = u.FullName;
                worksheet.Cell(i + 2, 4).Value = u.Dob?.ToString("dd/MM/yyyy");
                worksheet.Cell(i + 2, 5).Value = u.Phone;
                worksheet.Cell(i + 2, 6).Value = u.Gender.HasValue ? (u.Gender.Value ? "Male" : "Female") : "";
                worksheet.Cell(i + 2, 7).Value = u.IsActived;
                worksheet.Cell(i + 2, 8).Value = u.IsDeleted;
                worksheet.Cell(i + 2, 9).Value = u.CreatedAt.ToString("dd/MM/yyyy");
                worksheet.Cell(i + 2, 10).Value = u.UpdatedAt?.ToString("dd/MM/yyyy");
                worksheet.Cell(i + 2, 11).Value = u.DeletedAt?.ToString("dd/MM/yyyy");
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Users.xlsx");
        }
    }
}