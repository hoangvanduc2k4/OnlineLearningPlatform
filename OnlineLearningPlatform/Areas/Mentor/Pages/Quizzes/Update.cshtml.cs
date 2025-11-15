using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using System.Security.Claims;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    [Authorize(Roles = "Mentor")]
    public class UpdateModel : PageModel
    {
        UserManager<User> _userManager;
        private readonly IQuizService _quizService;
        private readonly OnlineLearningDBContext _context;
        private readonly IHubContext<CRUDHub> _hub;

        public UpdateModel(UserManager<User> userManager, IQuizService quizService, OnlineLearningDBContext context, IHubContext<CRUDHub> hub)
        {
            _quizService = quizService;
            _context = context;
            _hub = hub;
            _userManager = userManager;
        }

        [BindProperty]
        public QuizViewModel Quiz { get; set; }

        // public SelectList AvailableModules { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                var quiz = await _quizService.GetQuizByIdAsync(id, mentorId);
                if (quiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found.";
                    return RedirectToPage("./Index");
                }

                Quiz = quiz;

                var module = await _context.Modules
                    .AsNoTracking()
                    .Include(m => m.Course) 
                    .FirstOrDefaultAsync(m => m.ModuleId == Quiz.ModuleId && m.Course.Creator == mentorId);

                if (module == null)
                {
                    return Forbid(); 
                }

                ViewData["CourseName"] = module.Course.CourseName;
                ViewData["ModuleName"] = module.ModuleName;
                ViewData["CourseId"] = module.CourseId;
                ViewData["QuizId"] = id;

                Quiz.CourseId = module.CourseId;

                return Page();
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToPage("./Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while loading the quiz.";
                return RedirectToPage("./Index");
            }
        }


        public async Task<IActionResult> OnPostAsync()
        {
            // AvailableModules = new SelectList(_context.Modules.ToList(), "ModuleId", "ModuleName", Quiz.ModuleId);
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();
            if (!ModelState.IsValid)
            {
                var module = await _context.Modules
                    .AsNoTracking()
                    .Include(m => m.Course)
                    .FirstOrDefaultAsync(m => m.ModuleId == Quiz.ModuleId && m.Course.Creator == mentorId);

                if (module != null)
                {
                    ViewData["CourseName"] = module.Course.CourseName;
                    ViewData["ModuleName"] = module.ModuleName;
                    ViewData["CourseId"] = module.CourseId;
                }
                return Page();
            }

            try
            {
                var existingQuiz = await _quizService.GetQuizByIdAsync(Quiz.QuizId, mentorId);
                if (existingQuiz == null)
                {
                    TempData["ErrorMessage"] = "Quiz not found.";
                    return RedirectToPage("./Index");
                }

                existingQuiz.QuizName = Quiz.QuizName;
                existingQuiz.ModuleId = Quiz.ModuleId;
                existingQuiz.QuizTime = Quiz.QuizTime;
                existingQuiz.TimeUnit = Quiz.TimeUnit;
                existingQuiz.PassScore = Quiz.PassScore;

                await _quizService.UpdateQuizAsync(existingQuiz);
                await _hub.Clients.All.SendAsync("loadQuizzes");


                return RedirectToPage("/Courses/Manage", new { area = "Mentor", id = Quiz.CourseId });
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToPage("./Index");
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while updating the quiz.";
                return RedirectToPage("./Index");
            }
        }

        public async Task<IActionResult> OnPostDeleteAsync()
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);
            if (string.IsNullOrEmpty(mentorId)) return Forbid();

            var success = await _quizService.HideQuizAsync(Quiz.QuizId, mentorId);

            if (!success)
            {
                TempData["ErrorMessage"] = "Failed to delete quiz or quiz not found.";
                return RedirectToPage(new { id = Quiz.QuizId });
            }

            await _hub.Clients.All.SendAsync("loadQuizzes");


            return RedirectToPage("/Courses/Manage", new { area = "Mentor", id = Quiz.CourseId });
        }
    }
}
