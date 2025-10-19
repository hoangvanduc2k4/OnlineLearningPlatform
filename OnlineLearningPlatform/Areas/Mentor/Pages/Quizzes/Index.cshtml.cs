using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    [Authorize(Roles = "Mentor")]
    public class IndexModel : PageModel
    {
        
        public void OnGet()
        {
        }
    }
}
