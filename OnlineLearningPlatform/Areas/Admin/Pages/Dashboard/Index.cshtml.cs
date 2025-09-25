using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineLearningPlatform.Areas.Admin.Pages.Dashboard
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {


        public IndexModel()
        {
        }

        public string DashboardEmbedUrl { get; set; }

        public void OnGet()
        {

            DashboardEmbedUrl = "https://lookerstudio.google.com/embed/reporting/ee8d865e-6f9b-494c-b0ac-4d9b69349073";

        }

    }
}
