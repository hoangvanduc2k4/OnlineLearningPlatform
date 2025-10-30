using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services;
using OnlineLearningPlatform.Services.Interfaces;
using System;
using X.PagedList;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Areas.Mentor.Pages.Quizzes
{
    [Authorize(Roles = "Mentor")]
    public class IndexModel : PageModel
    {
        UserManager<User> _userManager;
        private readonly IQuizService _quizService;
        private readonly IHubContext<CRUDHub> _hub;
        public IndexModel(UserManager<User> userManager, IQuizService quizService, OnlineLearningDBContext context, IHubContext<CRUDHub> hub)
        {
            _quizService = quizService;
            _context = context;
            _hub = hub;
            _userManager = userManager;
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
            var user = await _userManager.GetUserAsync(User);
            var userId = await _userManager.GetUserIdAsync(user);
            var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault() ?? "Mentor";

            PageSize = pageSize ?? 10;
            SearchTerm = searchTerm;
            FilterType = string.IsNullOrWhiteSpace(filterType) ? "active" : filterType;

            // Lấy danh sách module (để hiển thị trong dropdown filter) -- giả sử service có method này
            // dung dbcontext tạm, sau này bảo long làm xong repository rồi sửa lại
            //var modules = await _quizService.GetAllModulesAsync();
            AvailableModules = await _context.Modules
    .Include(m => m.Course)
    .Where(m => m.Course.Creator == userId)
    .ToListAsync();
            SelectedModule = moduleId > 0
    ? AvailableModules.FirstOrDefault(m => m.ModuleId == moduleId)
    : null;


            // Lấy quiz theo filter type
            IEnumerable<QuizViewModel> quizzes = FilterType switch
            {
                "inactive" => await _quizService.GetInactiveQuizzesAsync(searchTerm, userId, role),
                _ => await _quizService.GetActiveQuizzesAsync(searchTerm, userId, role),
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
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                var quiz = await _quizService.GetQuizByIdAsync(id, mentorId);
                if (quiz != null)
                {
                    await _quizService.DeleteQuizByIdAsync(quiz.QuizId);
                    await _hub.Clients.All.SendAsync("loadQuizzes");
                    TempData["SuccessMessage"] = "Quiz deleted successfully.";
                }
                else
                {
                    TempData["ErrorMessage"] = "Quiz not found.";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi xóa quiz.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, moduleId);
        }



        public async Task OnPostDeactivateAsync(long id, int? pageNumber, int? pageSize, string searchTerm, string filterType, int moduleId)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                var quiz = await _quizService.GetQuizByIdAsync(id, mentorId);
                if (quiz != null)
                {
                    quiz.IsActived = false;
                    await _quizService.UpdateQuizAsync(quiz);
                    await _hub.Clients.All.SendAsync("loadQuizzes");
                    TempData["SuccessMessage"] = "Quiz deactivated successfully.";
                }
                else
                {
                    TempData["ErrorMessage"] = "Quiz not found.";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi vô hiệu hóa quiz.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, moduleId);
        }


        public async Task OnPostActivateAsync(long id, int? pageNumber, int? pageSize, string searchTerm, string filterType, int moduleId)
        {
            var mentor = await _userManager.GetUserAsync(User);
            var mentorId = await _userManager.GetUserIdAsync(mentor);

            try
            {
                var quiz = await _quizService.GetQuizByIdAsync(id, mentorId);
                if (quiz != null)
                {
                    quiz.IsActived = true;
                    await _quizService.UpdateQuizAsync(quiz);
                    await _hub.Clients.All.SendAsync("loadQuizzes");
                    TempData["SuccessMessage"] = "Quiz activated successfully.";
                }
                else
                {
                    TempData["ErrorMessage"] = "Quiz not found.";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "Đã xảy ra lỗi khi kích hoạt quiz.";
            }

            await OnGetAsync(pageNumber, pageSize, searchTerm, filterType, moduleId);
        }

    }
}
