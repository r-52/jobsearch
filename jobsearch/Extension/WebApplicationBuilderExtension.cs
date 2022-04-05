public static class WebApplicationBuilderExtension
{
    public static void AddDatabaseContext(this WebApplicationBuilder builder)
    {
#if DEBUG
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();
#endif
        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
    }

    public static void AddRedisCacheAndSession(this WebApplicationBuilder builder)
    {

        builder.Services.AddStackExchangeRedisCache(options =>
         {
             options.Configuration = builder.Configuration.GetConnectionString("DefaultRedisConnection");
         });

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromSeconds(60);
            options.Cookie.IsEssential = true;
        });
    }

    public static void AddLogging(this WebApplicationBuilder builder)
    {
        builder.Logging.ClearProviders();
        builder.Logging.AddSimpleConsole();
    }

    public static void AddSwagger(this WebApplicationBuilder builder)
    {

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "jobsearch API",
                Description = "the jobsearch api",
                Version = "v1"
            });
        });
    }
}
