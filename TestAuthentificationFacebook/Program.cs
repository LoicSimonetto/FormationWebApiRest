using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TestAuthentificationFacebook.Areas.Identity.Data;
using TestAuthentificationFacebook.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TestAuthentificationFacebookContextConnection") ?? throw new InvalidOperationException("Connection string 'TestAuthentificationFacebookContextConnection' not found.");

builder.Services.AddDbContext<TestAuthentificationFacebookContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<TestAuthentificationFacebookUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<TestAuthentificationFacebookContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = builder.Configuration["apis:facebook:id"];
    options.AppSecret = builder.Configuration["apis:facebook:secret"];
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseCookiePolicy();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();




app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
});



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
