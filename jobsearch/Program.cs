var builder = WebApplication.CreateBuilder(args);

builder.AddDatabaseContext();
builder.AddLogging();
builder.AddRedisCacheAndSession();
builder.AddSwagger();
builder.Services.AddSpaStaticFiles(configuration: options => { options.RootPath = "wwwroot"; });

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var app = builder.Build();
app.UseSession();

#if DEBUG
app.UseSwagger();
app.UseSwaggerUI();
#endif


using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DataContext>();
    db.Database.Migrate();
}

app.MapGet("/api/v1/jobs", async (IUnitOfWork unitOfWork) =>
{
    var x = await unitOfWork.Jobs.GetAllAsync();
    return x;
});


app.UseSpaStaticFiles();
app.UseStaticFiles();
#if DEBUG
// app.UseAngularLocalDevelopmentServer("../jobsearch.Client");
#endif

app.Run();
