namespace OnlineLearningPlarform.Configurations
{
    public static class SessionConfig
    {
        public static void ConfigureSession(this IServiceCollection services)
        {
            services.AddDistributedMemoryCache(); 
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

    }
}
