// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Attributes;
using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [StringLength(2000)]
            [Url(ErrorMessage = "AvatarUrl must be a valid URL")]
            public string? AvatarUrl { get; set; }

            [Display(Name = "Avatar")]
            [FileValidate]
            public IFormFile? Avatar { get; set; }

            [StringLength(255)]
            [Required]
            [Display(Name = "Full name")]
            public string? FullName { get; set; }

            [DataType(DataType.Date)]
            [DateValidate(ErrorMessage = "Date of birth must be in the past")]
            [Display(Name = "Date of birth")]
            public DateOnly? Dob { get; set; }

            [Display(Name = "Gender")]
            public bool? Gender { get; set; }

            [Phone]
            [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must be exactly 10 digits")]
            [RegularExpression(@"^(0[0-9]{9})$", ErrorMessage = "Phone number is invalid")]
            [Display(Name = "Phone number")]
            public string? PhoneNumber { get; set; }
        }

        private async Task LoadAsync(User user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                FullName = user.FullName,
                Dob = user.Dob,
                PhoneNumber = user.PhoneNumber,
                Gender = user.Gender,
                AvatarUrl = user.AvatarUrl,

            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
            if (Input.Avatar != null && Input.Avatar.Length > 0)
            {
                var wwwRootPath = _webHostEnvironment.WebRootPath;
                var fileName = $"{user.Id}_{Path.GetFileName(Input.Avatar.FileName)}";
                var filePath = Path.Combine(wwwRootPath, "uploads", "avatars", fileName);
                Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Input.Avatar.CopyToAsync(stream);
                }
                user.AvatarUrl = $"/uploads/avatars/{fileName}";
            }
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            bool hasChanges = false;
            if (Input.FullName != user.FullName)
            {
                user.FullName = Input.FullName;
                hasChanges = true;
            }

            if (Input.Dob != user.Dob)
            {
                user.Dob = Input.Dob;
                hasChanges = true;
            }

            if (Input.Gender != user.Gender)
            {
                user.Gender = Input.Gender;
                hasChanges = true;
            }

            if (hasChanges || (Input.Avatar != null && Input.Avatar.Length > 0))
            {
                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    StatusMessage = "Error: Unexpected error when trying to update profile.";
                    foreach (var error in updateResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    await LoadAsync(user);
                    return Page();
                }
            }


            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
