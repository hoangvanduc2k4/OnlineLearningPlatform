using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Levels
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ILevelService _levelService;
        private readonly IHubContext<CRUDHub> _hub;

        public IndexModel(ILevelService levelService, IHubContext<CRUDHub> hub)
        {
            _levelService = levelService;
            _hub = hub;
        }

        public List<Level> Levels { get; set; }

        public async Task OnGetAsync()
        {
            Levels = (await _levelService.GetAllLevelAysnc()).ToList();
        }

        public async Task OnPostDeleteAsync(long id)
        {
            var level = await _levelService.GetLevelByIdAsync(id);
            if (level != null)
            {
                await _levelService.DeleteLevelAsync(level);
                await _hub.Clients.All.SendAsync("LevelDeleted", level.LevelId);
                TempData["SuccessMessage"] = "Deleted successfully.";
            }
            Levels = (await _levelService.GetAllLevelAysnc()).ToList();
        }
    }
}
