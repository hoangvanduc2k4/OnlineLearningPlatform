using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services;
using OnlineLearningPlatform.Services.Interfaces;
using System;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    //[Authorize(Roles = "Mentor")]
    public class IndexModel : PageModel
    {
        private readonly IQuizService _quizService;

        public IndexModel(IQuizService quizService, OnlineLearningDBContext context)
        {
            _quizService = quizService;
            _context = context;
        }

        public IPagedList<QuizViewModel> PagedQuizzes { get; set; }

        public int PageSize { get; set; } = 10;
        public string SearchTerm { get; set; }
        public string FilterType { get; set; } = "active";
        public Module SelectedModule { get; set; }
        public List<Module> AvailableModules { get; set; } = new();
        //sau này sửa lại dùng repository + service
        protected readonly OnlineLearningDBContext _context;

        public async Task OnGetAsync(int? pageNumber, int? pageSize, string searchTerm, string filterType, int moduleId)
        {
            PageSize = pageSize ?? 10;
            SearchTerm = searchTerm;
            FilterType = string.IsNullOrWhiteSpace(filterType) ? "active" : filterType;

            // Lấy danh sách module (để hiển thị trong dropdown filter) -- giả sử service có method này
            // dung dbcontext tạm, sau này bảo long làm xong repository rồi sửa lại
            //var modules = await _quizService.GetAllModulesAsync();
             AvailableModules = _context.Modules.ToList();
            SelectedModule = moduleId > 0 ? _context.Modules.FirstOrDefault(m => m.ModuleId == moduleId) : null;


            // Lấy quiz theo filter type
            IEnumerable<QuizViewModel> quizzes = FilterType switch
            {
                "inactive" => await _quizService.GetInactiveQuizzesAsync(SearchTerm),
                _ => await _quizService.GetActiveQuizzesAsync(SearchTerm),
            };

            if (SelectedModule != null)
            {
                quizzes = quizzes.Where(q => q.ModuleId == SelectedModule.ModuleId);
            }

            int page = pageNumber ?? 1;
            PagedQuizzes = quizzes
                .OrderByDescending(q => q.QuizId) 
                .ToPagedList(page, PageSize);
        }
        public async Task OnPostDeleteAsync(long id, int? pageNumber, int? pageSize, string searchTerm, string filterType, int moduleId)
        {
            var quiz = await _quizService.GetQuizByIdAsync(id);
            if (quiz != null)
            {
                await _quizService.DeleteQuizByIdAsync(quiz.QuizId);
                TempData["SuccessMessage"] = "Quiz deleted successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Quiz not found.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, moduleId);
        }


        public async Task OnPostDeactivateAsync(long id, int? pageNumber, int? pageSize, string searchTerm, string filterType, int moduleId)
        {
            var quiz = await _quizService.GetQuizByIdAsync(id);
            if (quiz != null)
            {
                quiz.IsActived = false;
                await _quizService.UpdateQuizAsync(quiz);
                TempData["SuccessMessage"] = "Quiz deactivated successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Quiz not found.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, moduleId);
        }

        public async Task OnPostActivateAsync(long id, int? pageNumber, int? pageSize, string searchTerm, string filterType, int moduleId)
        {
            var quiz = await _quizService.GetQuizByIdAsync(id);
            if (quiz != null)
            {
                quiz.IsActived = true;
                await _quizService.UpdateQuizAsync(quiz);
                TempData["SuccessMessage"] = "Quiz activated successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Quiz not found.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, moduleId);
        }
    }
}
