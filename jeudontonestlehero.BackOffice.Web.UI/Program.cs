using jeudontonestlehero.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using jeudontonestlehero.BackOffice.Web.UI.Data;
using jeudontonestlehero.BackOffice.Web.UI.Constraints;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultContext");
builder.Services.AddDbContext<jeudontonestleheroBackOfficeWebUIContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

builder.Services.AddDbContext<DefaultContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<jeudontonestleheroBackOfficeWebUIContext>();

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

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy(new CookiePolicyOptions
{
    CheckConsentNeeded = context => true,
    MinimumSameSitePolicy = SameSiteMode.None
});

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
});




app.MapControllerRoute(
    name: "editparaf",
    pattern: "edition-paragraphe/{id}",
    defaults: new { controller = "Paragraphe", action = "Edit"},
    constraints: new { id = new LogConstraint() }
    //constraints: new { id = @"\d+"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
