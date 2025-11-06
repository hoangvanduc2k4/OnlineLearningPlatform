using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Lessons
{
    public class IndexModel : PageModel
    {
        private readonly OnlineLearningPlatform.Data.OnlineLearningDBContext _context;

        public IndexModel(OnlineLearningPlatform.Data.OnlineLearningDBContext context)
        {
            _context = context;
        }

        public IList<Lesson> Lesson { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Lesson = await _context.Lessons
                .Include(l => l.Module).ToListAsync();
        }
    }
}
