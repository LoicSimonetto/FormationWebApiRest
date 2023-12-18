using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Web.UI.Constraints;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc();

string connectionString = builder.Configuration.GetConnectionString("DefaultContext");
builder.Services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "creeraventure",
    pattern: "creer-mon-aventure",
    defaults: new { controller = "Aventure", action = "Add" }
    );

app.MapControllerRoute(
    name: "editaventure",
    pattern: "editer-une-aventure/{id}",
    defaults: new { controller = "Aventure", action = "Edit" },
    constraints: new { id = @"\d+" }
    );

app.MapControllerRoute(
    name: "mesaventures",
    pattern: "mes-aventures",
    defaults: new
    {
        controller = "Aventure",
        action = "Index",
    });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
