using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Mentee.Pages.MentorApplications
{
    [Authorize]
    [Area("Mentee")]
    public class MyApplicationsModel : PageModel
    {
        private readonly IMentorApplicationService _mentorApplicationService;
        private readonly IUserService _userService;

        public MyApplicationsModel(IMentorApplicationService mentorApplicationService, IUserService userService)
        {
            _mentorApplicationService = mentorApplicationService;
            _userService = userService;
        }

        public List<MentorApplication> Applications { get; set; } = new();

        public async Task OnGetAsync()
        {
            var user = await _userService.GetUserByIdAsync(User.Identity!.Name!);
            if (user != null)
            {
                var apps = await _mentorApplicationService.GetByUserIdAsync(user.Id);
                Applications = apps.ToList();
            }
        }
    }
}
