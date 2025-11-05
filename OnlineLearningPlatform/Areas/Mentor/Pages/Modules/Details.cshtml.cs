using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Modules
{
    public class DetailsModel : PageModel
    {
        private readonly OnlineLearningPlatform.Data.OnlineLearningDBContext _context;

        public DetailsModel(OnlineLearningPlatform.Data.OnlineLearningDBContext context)
        {
            _context = context;
        }

        public Module Module { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var module = await _context.Modules.FirstOrDefaultAsync(m => m.ModuleId == id);
            if (module == null)
            {
                return NotFound();
            }
            else
            {
                Module = module;
            }
            return Page();
        }
    }
}
