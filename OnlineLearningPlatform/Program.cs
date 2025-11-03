using OnlineLearningPlatform.Configurations;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Mappers;

// thêm using cho DI của Course
using OnlineLearningPlatform.Utils;

namespace OnlineLearningPlarform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.ConfigureAppSettings(builder);
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            builder.Services.ConfigureDatabase(builder.Configuration);
            builder.Services.ConfigureAuthentication(builder.Configuration);
            builder.Services.ConfigureDIRepoService(builder.Configuration);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSignalR();
            builder.Services.ConfigureSession();
            builder.Services.AddRazorPages();
            builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
            builder.Services.Configure<VnPayConfig>(builder.Configuration.GetSection("VnPay"));

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error/500");
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/Error/{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapHub<UserChatHub>("/userChatHub");
            app.MapHub<CRUDHub>("/crudHub");

            app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
