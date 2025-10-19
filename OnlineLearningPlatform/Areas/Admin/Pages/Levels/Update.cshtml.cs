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
    public class UpdateModel : PageModel
    {
        private readonly ILevelService _levelService;
        private readonly IHubContext<CRUDHub> _hub;

        public UpdateModel(ILevelService levelService, IHubContext<CRUDHub> hub)
        {
            _levelService = levelService;
            _hub = hub;
        }

        [BindProperty]
        public Level Level { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            Level = await _levelService.GetLevelByIdAsync(id);
            if (Level == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _levelService.UpdateLevelAsync(Level);
            await _hub.Clients.All.SendAsync("LevelUpdated", new
            {
                levelId = Level.LevelId,
                levelName = Level.LevelName,
                isDeleted = Level.IsDeleted
            });

            return RedirectToPage("./Index");
        }
    }
}
