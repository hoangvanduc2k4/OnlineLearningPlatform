using Microsoft.AspNetCore.Identity.UI.Services;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Repositories;
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




            //Add Service
            services.AddTransient<IEmailSender, EmailSenderService>();
            services.AddScoped<IFAQsService, FAQsService>();




            return services;
        }
    }
}
