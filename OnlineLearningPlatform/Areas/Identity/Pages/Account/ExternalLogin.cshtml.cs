// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using OnlineLearningPlatform.Models.Entities.UserPart;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace OnlineLearningPlatform.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ExternalLoginModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<ExternalLoginModel> _logger;

        public ExternalLoginModel(
            SignInManager<User> signInManager,
            UserManager<User> userManager,
            IUserStore<User> userStore,
            ILogger<ExternalLoginModel> logger,
            IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _logger = logger;
            _emailSender = emailSender;
        }

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
        public string ProviderDisplayName { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public IActionResult OnGet() => RedirectToPage("./Login");

        public IActionResult OnPost(string provider, string returnUrl = null)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> OnGetCallbackAsync(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (remoteError != null)
            {
                ErrorMessage = $"Lỗi từ nhà cung cấp bên ngoài: {remoteError}";
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = "Lỗi khi tải thông tin đăng nhập từ bên ngoài.";
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            // --- START FIX (Kiểm tra người dùng đã liên kết) ---
            // Tìm user đã được liên kết với tài khoản ngoài này
            var user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
            if (user != null)
            {
                if (user.IsDeleted)
                {
                    ErrorMessage = "Tài khoản này đã bị xóa.";
                    return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
                }

                if (!user.IsActived)
                {
                    ErrorMessage = "Tài khoản này đã bị vô hiệu hóa. Vui lòng liên hệ quản trị viên.";
                    return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
                }
            }
            // --- END FIX ---


            // Sign in the user with this external login provider if the user already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                _logger.LogInformation("{Name} logged in with {LoginProvider} provider.", info.Principal.Identity.Name, info.LoginProvider);
                return LocalRedirect(returnUrl);
            }
            if (result.IsLockedOut)
            {
                return RedirectToPage("./Lockout");
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ReturnUrl = returnUrl;
                ProviderDisplayName = info.ProviderDisplayName;
                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    Input = new InputModel
                    {
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };
                }
                return Page();
            }
        }

        // --- HÀM NÀY ĐƯỢC VIẾT LẠI HOÀN TOÀN ĐỂ FIX ---
        public async Task<IActionResult> OnPostConfirmationAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            // Get the information about the user from the external login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = "Lỗi khi tải thông tin đăng nhập từ bên ngoài.";
                return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                // Tìm xem user đã tồn tại bằng email chưa
                var user = await _userManager.FindByEmailAsync(Input.Email);
                IdentityResult result;

                if (user == null)
                {
                    // Trường hợp 1: User chưa tồn tại -> Tạo user mới
                    user = CreateUser();
                    await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                    await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

                    // Lấy FullName từ Google/Facebook nếu có
                    if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Name))
                    {
                        user.FullName = info.Principal.FindFirstValue(ClaimTypes.Name);
                    }

                    // Lấy AvatarUrl từ Google/Facebook nếu có (ClaimType này có thể khác nhau)
                    if (info.Principal.HasClaim(c => c.Type == "picture")) // Thử claim "picture"
                    {
                        user.AvatarUrl = info.Principal.FindFirstValue("picture");
                    }

                    // Tạo user mới (IsDeleted=false, IsActived=true theo default)
                    result = await _userManager.CreateAsync(user);

                    // Thêm role cho user mới
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Mentee"); // Thêm role "Mentee"
                    }
                }
                else
                {
                    // Trường hợp 2: User đã tồn tại -> Kiểm tra trạng thái
                    if (user.IsDeleted)
                    {
                        ModelState.AddModelError(string.Empty, "Tài khoản này đã bị xóa.");
                        ProviderDisplayName = info.ProviderDisplayName;
                        ReturnUrl = returnUrl;
                        return Page();
                    }

                    if (!user.IsActived)
                    {
                        ModelState.AddModelError(string.Empty, "Tài khoản này đã bị vô hiệu hóa.");
                        ProviderDisplayName = info.ProviderDisplayName;
                        ReturnUrl = returnUrl;
                        return Page();
                    }

                    // Nếu user OK -> coi như thành công để tiếp tục liên kết
                    result = IdentityResult.Success;
                }

                if (result.Succeeded)
                {
                    // Liên kết tài khoản ngoài (Google/FB) với user (mới hoặc cũ)
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User linked a {Name} account.", info.LoginProvider);

                        // Gửi email xác thực
                        var userId = await _userManager.GetUserIdAsync(user);
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            "/Account/ConfirmEmail",
                            pageHandler: null,
                            values: new { area = "Identity", userId = userId, code = code },
                            protocol: Request.Scheme);

                        await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                            $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                        // Nếu cần xác thực tài khoản, chuyển đến trang thông báo
                        if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        {
                            return RedirectToPage("./RegisterConfirmation", new { Email = Input.Email });
                        }

                        // Đăng nhập cho user
                        await _signInManager.SignInAsync(user, isPersistent: false, info.LoginProvider);
                        return LocalRedirect(returnUrl);
                    }
                }

                // Nếu có lỗi (tạo user, liên kết...)
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            ProviderDisplayName = info.ProviderDisplayName;
            ReturnUrl = returnUrl;
            return Page();
        }
        // --- KẾT THÚC HÀM ĐÃ VIẾT LẠI ---

        private User CreateUser()
        {
            try
            {
                return Activator.CreateInstance<User>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(User)}'. " +
                    $"Ensure that '{nameof(User)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the external login page in /Areas/Identity/Pages/Account/ExternalLogin.cshtml");
            }
        }

        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }
    }
}