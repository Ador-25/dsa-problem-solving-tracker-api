using DSA_Tracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DSA_Tracker.Areas.Identity.Data;
using DSA_Tracker.Models;

var builder = WebApplication.CreateBuilder(args);

//for identity database=> 
builder.Services.AddDbContext<IdentityDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityDbContextConnection")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<IdentityDbContext>();


builder.Services.AddControllersWithViews();

// add application db context
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DsaConnection")));


// add services
builder.Services.AddScoped<IProblemData, SqlProblemData>();


// add google authentication
builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
{
    googleOptions.ClientId = "630347173667-716ei4o8i70dlken2jq69ui5ccvfh228.apps.googleusercontent.com";
    googleOptions.ClientSecret = "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";
});

//builder.Services.AddAuthentication()
//    .AddFacebook(options =>
//    {
//        options.AppId = "test";
//        options.AppSecret = "test";
//    })
//    .AddGoogle(options =>
//    {
//        options.ClientId = "test";
//        options.ClientSecret = "test";
//    });
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); 
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// for razor pages
app.MapRazorPages();

app.Run();
