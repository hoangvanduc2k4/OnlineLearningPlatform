using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IModuleService
    {
        Task<IEnumerable<SelectListItem>> GetCoursesForDropdownAsync(string mentorId);

        Task<Module> CreateModuleAsync(ModuleInputViewModel viewModel);
        Task<ModuleInputViewModel?> GetModuleForEditAsync(long moduleId, string mentorId);

        Task<bool> UpdateModuleAsync(ModuleInputViewModel viewModel, string mentorId);
        Task<bool> HideModuleAsync(long moduleId, string mentorId);
    }
}
