using Microsoft.AspNetCore.Identity.UI.Services;
using OnlineLearningPlatform.Repositories;
using OnlineLearningPlatform.Repositories.Implementations;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services;
using OnlineLearningPlatform.Services.Implementations;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Configurations
{
    public static class DIConfig
    {
        public static IServiceCollection ConfigureDIRepoService(this IServiceCollection services, IConfiguration configuration)
        {
            //User repository
            services.AddScoped<IUserRepository, UserRepository>();

            //Email Service
            services.AddTransient<IEmailSender, EmailSenderService>();

            //FAQ
            services.AddScoped<IFAQsRepository, FAQsRepository>();
            services.AddScoped<IFAQsService, FAQsService>();

            //message
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IMessageService, MessageService>();



            return services;
        }
    }
}
