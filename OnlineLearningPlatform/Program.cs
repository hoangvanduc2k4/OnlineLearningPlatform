using OnlineLearningPlatform.Configurations;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Mappers;
using OnlineLearningPlatform.Repositories;
// thêm using cho DI của Course
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services;
using OnlineLearningPlatform.Services.Interfaces;
using OnlineLearningPlatform.Utils;

namespace OnlineLearningPlarform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Configuration.ConfigureAppSettings(builder);

            // AutoMapper - scan toàn bộ Profiles trong assembly chứa AutoMapperProfile
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            builder.Services.ConfigureDatabase(builder.Configuration);
            builder.Services.ConfigureAuthentication(builder.Configuration);
            builder.Services.ConfigureDIRepoService(builder.Configuration);

            // --- ĐĂNG KÝ RIÊNG CHO COURSES (Repository + Service) ---
            // Nếu bạn đã đăng ký toàn bộ repo/service trong ConfigureDIRepoService, 
            // những dòng bên dưới có thể bị thừa — nhưng explicit đăng ký ở đây đảm bảo an toàn.
            builder.Services.AddScoped<ICourseRepository, CoursesRepository>();
            builder.Services.AddScoped<ICourseService, CoursesService>();
            builder.Services.AddScoped<IRatingRepository, RatingRepository>(); // Thêm dòng này

            // ----------------------------------------------------------------

            builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();
            builder.Services.ConfigureSession();
            builder.Services.AddRazorPages();
            builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapHub<UserChatHub>("/userChatHub");
            app.MapHub<CRUDHub>("/crudHub");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
