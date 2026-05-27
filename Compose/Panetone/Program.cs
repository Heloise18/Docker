using Microsoft.EntityFrameworkCore;
using Panetone.Contexts;
using Panetone.Endpoints;
using Panetone.UseCases.CreateTask;
using Panetone.UseCases.GetAllTask;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PanetoneContext>(options =>
{

    var host = Environment.GetEnvironmentVariable("DB_HOST"); // caminho
    var port = Environment.GetEnvironmentVariable("DB_PORT"); // porta
    var dtbs = Environment.GetEnvironmentVariable("DB_DB"); //nome 
    var user = Environment.GetEnvironmentVariable("DB_USER"); //sa
    var pass = Environment.GetEnvironmentVariable("DB_PASS"); //senha
    
    var sqlConn = $"Server={host},{port};Database={dtbs};User Id={user};Password={pass};TrustServerCertificate=True";
    options.UseSqlServer(sqlConn);
});

builder.Services.AddTransient<CreateTaskUsecase>();
builder.Services.AddTransient<GetAllTaskUsecase>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PanetoneContext>();
    db.Database.Migrate();
}

app.ConfigureTaskEndpoints();
app.Run();