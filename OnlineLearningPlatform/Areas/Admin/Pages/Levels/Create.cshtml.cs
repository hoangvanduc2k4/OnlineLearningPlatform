using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Levels
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly ILevelService _levelService;
        private readonly IHubContext<CRUDHub> _hub;

        public CreateModel(ILevelService levelService, IHubContext<CRUDHub> hub)
        {
            _levelService = levelService;
            _hub = hub;
        }

        [BindProperty]
        public Level Level { get; set; } = new Level { IsDeleted = false };

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _levelService.AddLevelAsync(Level);
            await _hub.Clients.All.SendAsync("LevelCreated", new
            {
                levelId = Level.LevelId,
                levelName = Level.LevelName,
                isDeleted = Level.IsDeleted
            });
            return RedirectToPage("./Index");
        }

    }
}
