var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DataContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("v1", new OpenApiInfo {
         Title = "jobsearch API",
         Description = "the jobsearch api",
         Version = "v1" });
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
