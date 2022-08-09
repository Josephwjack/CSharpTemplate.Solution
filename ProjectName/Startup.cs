using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PROJECTNAME.Models;

namespace PROJECTNAME
{
  public class Startup
  {
    public Startup(IWebHostEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables()
          .AddJsonFile("appsettings.json");
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddEntityFrameworkMySql()
        .AddDbContext<PROJECTNAMEContext>(options => options
        .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
      services.AddIdentity<ApplicationUser, IdentityRole>()
              .AddEntityFrameworkStores<PROJECTNAMEContext>()
              .AddDefaultTokenProviders();
      services.Configure<IdentityOptions>(options =>
      {
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 0;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredUniqueChars = 0;
      });
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();
      app.UseAuthentication();
      app.UseRouting();

      app.UseAuthorization();
      app.UseEndpoints(routes =>
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });
      app.UseStaticFiles();
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("View not found.");
      });
    }
  }

}