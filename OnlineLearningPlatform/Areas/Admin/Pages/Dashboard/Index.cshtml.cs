using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Dashboard
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {

        private readonly IStatisticService _statisticService;

        public IndexModel(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public DashboardViewModel Statistics { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? StartDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? EndDate { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Statistics = await _statisticService.GetDashboardStatisticsAsync(StartDate, EndDate);
            return Page();
        }

    }
}
