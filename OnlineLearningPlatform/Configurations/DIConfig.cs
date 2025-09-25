using Microsoft.AspNetCore.Identity.UI.Services;
using OnlineLearningPlatform.Repositories;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Configurations
{
    public static class DIConfig
    {
        public static IServiceCollection ConfigureDIRepoService(this IServiceCollection services, IConfiguration configuration)
        {

            //Add Repository
            services.AddScoped<IFAQsRepository, FAQsRepository>();
            services.AddScoped<ILevelRepository, LevelRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();



            //Add Service
            services.AddTransient<IEmailSender, EmailSenderService>();
            services.AddScoped<IFAQsService, FAQsService>();
            services.AddScoped<ILevelService, LevelService>();
            services.AddScoped<ICategoryService, CategoryService>();



            return services;
        }
    }
}
