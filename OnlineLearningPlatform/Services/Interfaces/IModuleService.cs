using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IModuleService
    {
        Task<IEnumerable<SelectListItem>> GetCoursesForDropdownAsync(string mentorId);

        Task CreateModuleAsync(ModuleInputViewModel viewModel);
        Task<ModuleInputViewModel?> GetModuleForEditAsync(long moduleId, string mentorId);

        Task<bool> UpdateModuleAsync(ModuleInputViewModel viewModel, string mentorId);
    }
}
