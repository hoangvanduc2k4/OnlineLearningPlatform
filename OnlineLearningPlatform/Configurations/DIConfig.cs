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

            //Add Repository
            services.AddScoped<IFAQsRepository, FAQsRepository>();
            services.AddScoped<ILevelRepository, LevelRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IEmailSender, EmailSenderService>();

            //FAQ
            services.AddScoped<IFAQsRepository, FAQsRepository>();
            services.AddScoped<IFAQsService, FAQsService>();

            //message
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IMessageService, MessageService>();

            //level

            //user
            services.AddScoped<IUserService, UserService>();
            //role
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();


            services.AddScoped<ILevelService, LevelService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<ICourseRepository, CoursesRepository>();
            services.AddScoped<ICourseService, CoursesService>();
            services.AddScoped<IRatingRepository, RatingRepository>();

            services.AddScoped<ICourseEnrollmentRepository, CourseEnrollmentRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IVnPayService, VnPayService>();
            services.AddScoped<ITransactionService, TransactionService>();

            services.AddScoped<IAdminReviewCourseRepository, AdminReviewCourseRepository>();



            services.AddScoped<ICourseEnrollmentService, CourseEnrollmentService>();

            //quiz
            services.AddScoped<IQuizRepository, QuizRepository>();
            services.AddScoped<IQuizService, QuizService>();
            // question
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionService, QuestionService>();

            return services;
        }
    }
}
