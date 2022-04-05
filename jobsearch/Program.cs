var builder = WebApplication.CreateBuilder(args);

builder.AddDatabaseContext();
builder.AddLogging();
builder.AddRedisCacheAndSession();
builder.AddSwagger();
builder.Services.AddSpaStaticFiles(configuration: options => { options.RootPath = "wwwroot"; });
var app = builder.Build();
app.UseSession();

#if DEBUG
app.UseSwagger();
app.UseSwaggerUI();
#endif

app.UseSpaStaticFiles();
app.UseStaticFiles();
#if DEBUG
app.UseAngularLocalDevelopmentServer("../jobsearch.Client");
#endif


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DataContext>();
    db.Database.Migrate();
}

app.MapGet("/", () => "Hello World!");
app.Run();
