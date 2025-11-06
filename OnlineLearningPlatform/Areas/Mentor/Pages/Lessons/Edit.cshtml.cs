using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.CoursePart;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Lessons
{
    public class EditModel : PageModel
    {
        private readonly OnlineLearningPlatform.Data.OnlineLearningDBContext _context;

        public EditModel(OnlineLearningPlatform.Data.OnlineLearningDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lesson Lesson { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson =  await _context.Lessons.FirstOrDefaultAsync(m => m.LessonId == id);
            if (lesson == null)
            {
                return NotFound();
            }
            Lesson = lesson;
           ViewData["ModuleId"] = new SelectList(_context.Modules, "ModuleId", "ModuleName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(Lesson.LessonId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LessonExists(long id)
        {
            return _context.Lessons.Any(e => e.LessonId == id);
        }
    }
}
