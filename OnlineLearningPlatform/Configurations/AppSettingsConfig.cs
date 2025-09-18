namespace OnlineLearningPlarform.Configurations
{
    public static class AppSettingsConfig
    {
        public static IConfigurationBuilder ConfigureAppSettings(this IConfigurationBuilder builder, WebApplicationBuilder webBuilder)
        {
            return builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
        }

    }
}
