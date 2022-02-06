using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using MyCarApp.Data;
using MyCarApp.Data.Models;
using MyCarApp.Services.Constants;
using NLog;
using NLog.Web;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");
try
{
    var builder = WebApplication.CreateBuilder(args);
    // Add services to the container.
    builder.Services.AddDbContext<MyCarAppDbContext>(options => options.UseSqlServer(builder.Configuration[ConfigurationNamesConstants.ConnectionString]));
    builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
        .AddEntityFrameworkStores<MyCarAppDbContext>();

    builder.Services.AddIdentityServer()
        .AddApiAuthorization<User, MyCarAppDbContext>();

    builder.Services.AddAuthentication()
        .AddIdentityServerJwt();

    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseMigrationsEndPoint();
    }
    else
    {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();

    app.UseAuthentication();
    app.UseIdentityServer();
    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
    app.MapRazorPages();

    app.MapFallbackToFile("index.html"); ;

    app.Run();

}
catch (Exception exception)
{
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}