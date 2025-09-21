using Microsoft.AspNetCore.Identity.UI.Services;
using OnlineLearningPlatform.Services;

namespace OnlineLearningPlatform.Configurations
{
    public static class DIConfig
    {
        public static IServiceCollection ConfigureDIRepoService(this IServiceCollection services, IConfiguration configuration)
        {

            //Add Repository




            //Add Service
            services.AddTransient<IEmailSender, EmailSenderService>();



            return services;
        }
    }
}
