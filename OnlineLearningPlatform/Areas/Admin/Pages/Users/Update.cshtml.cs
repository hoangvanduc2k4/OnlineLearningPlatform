using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Users
{
    public class UpdateModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IHubContext<CRUDHub> _hubContext;


        public UpdateModel(IUserService userService, IRoleService roleService, IHubContext<CRUDHub> hubContext)
        {
            _userService = userService;
            _roleService = roleService;
            _hubContext = hubContext;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public SelectList AvailableRoles { get; set; }
        public string? ErrorMessage { get; set; }

        [BindProperty]
        public IFormFile? AvatarFile { get; set; }

        public class InputModel
        {
            public string Id { get; set; }
            [EmailAddress]
            public string Email { get; set; }
            [StringLength(255)]
            public string? FullName { get; set; }
            [DataType(DataType.Date)]
            public DateOnly? Dob { get; set; }
            public bool? Gender { get; set; }
            [StringLength(20)]
            public string? Phone { get; set; }
            public bool IsActived { get; set; }
            public List<string> SelectedRoles { get; set; } = new();
            public string? AvatarUrl { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                ErrorMessage = "User not found.";
                return Page();
            }

            Input = new InputModel
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                Dob = user.Dob,
                Gender = user.Gender,
                Phone = user.Phone,
                IsActived = user.IsActived,
                SelectedRoles = (await _roleService.GetUserRolesAsync(user.Id)).ToList(),
                AvatarUrl = user.AvatarUrl
            };

            var allRoles = await _roleService.GetAllRolesAsync();
            AvailableRoles = new SelectList(allRoles, "Name", "Name", Input.SelectedRoles);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var allRoles = await _roleService.GetAllRolesAsync();
                AvailableRoles = new SelectList(allRoles, "Name", "Name", Input.SelectedRoles);
                return Page();
            }

            var user = await _userService.GetUserByIdAsync(Input.Id);
            if (user == null)
            {
                ErrorMessage = "User not found.";
                return Page();
            }

            user.FullName = Input.FullName;
            user.Dob = Input.Dob;
            user.Gender = Input.Gender;
            user.Phone = Input.Phone;
            user.IsActived = Input.IsActived;

            if (AvatarFile != null && AvatarFile.Length > 0)
            {
                var fileName = $"{Input.Id}_{Path.GetFileName(AvatarFile.FileName)}";
                var filePath = Path.Combine("wwwroot", "uploads", "avatars", fileName);

                Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await AvatarFile.CopyToAsync(stream);
                }

                Input.AvatarUrl = $"/uploads/avatars/{fileName}";
                user.AvatarUrl = Input.AvatarUrl;
            }

            await _userService.UpdateUserAsync(user);

            // Update roles
            var currentRoles = await _roleService.GetUserRolesAsync(user.Id);
            var rolesToAdd = Input.SelectedRoles.Except(currentRoles).ToList();
            var rolesToRemove = currentRoles.Except(Input.SelectedRoles).ToList();

            foreach (var role in rolesToAdd)
                await _roleService.AddUserToRoleAsync(user.Id, role);
            foreach (var role in rolesToRemove)
                await _roleService.RemoveUserFromRoleAsync(user.Id, role);
            await _hubContext.Clients.All.SendAsync("LoadUsers");
            TempData["SuccessMessage"] = "User updated successfully.";
            return RedirectToPage("Index");
        }
    }
}