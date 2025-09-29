using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Levels
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly ILevelService _levelService;

        public IndexModel(ILevelService levelService)
        {
            _levelService = levelService;
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
            }
            TempData["SuccessMessage"] = "Deleted successfully.";
            Levels = (await _levelService.GetAllLevelAysnc()).ToList();
        }
    }
}
