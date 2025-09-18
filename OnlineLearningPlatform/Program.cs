using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlarform.Configurations;
using OnlineLearningPlarform.Mappers;
using OnlineLearningPlarform.Data;

namespace OnlineLearningPlarform
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Configuration.ConfigureAppSettings(builder);
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
            builder.Services.ConfigureDatabase(builder.Configuration);
            builder.Services.ConfigureAuthentication(builder.Configuration);
            builder.Services.ConfigureDIRepoService(builder.Configuration);
            builder.Services.AddControllersWithViews();
            builder.Services.ConfigureSession();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
