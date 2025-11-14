using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;

namespace OnlineLearningPlatform.Areas.Mentee.Pages.MentorApplications
{
    [Authorize]
    [Area("Mentee")]
    public class ApplyModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IMentorApplicationService _mentorAppService;
        private readonly IWebHostEnvironment _env;
        private readonly IHubContext<CRUDHub> _hubContext;

        public ApplyModel(IUserService userService, IMentorApplicationService mentorAppService, IWebHostEnvironment env, IHubContext<CRUDHub> hubContext)
        {
            _userService = userService;
            _mentorAppService = mentorAppService;
            _env = env;
            _hubContext = hubContext;
        }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public string? ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            public IFormFile CvFile { get; set; } = null!;

            [StringLength(4000)]
            public string? Note { get; set; }
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            var user = await _userService.GetUserByNameAsync(User.Identity!.Name!);
            if (user == null)
            {
                ErrorMessage = "User not found.";
                return Page();
            }

            // Save CV file
            var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads", "cv");
            Directory.CreateDirectory(uploadsFolder);
            var fileName = $"{Guid.NewGuid()}_{Input.CvFile.FileName}";
            var filePath = Path.Combine(uploadsFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await Input.CvFile.CopyToAsync(stream);
            }

            var mentorApp = new MentorApplication
            {
                UserId = user.Id,
                CvUrl = $"/uploads/cv/{fileName}",
                Note = Input.Note,
                Status = OnlineLearningPlatform.Enums.ApplicationStatus.Pending,
                SubmittedAt = DateTime.UtcNow
            };

            await _mentorAppService.CreateAsync(mentorApp);

            // Notify admins (and other clients) that mentor applications changed
            await _hubContext.Clients.All.SendAsync("loadMentorApplications");

            TempData["SuccessMessage"] = "Application submitted successfully!";
            return RedirectToPage("./Apply");
        }
    }
}
