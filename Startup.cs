using Microsoft.AspNet.Builder;
using TheWorld.Services;
using Microsoft.Dnx.Runtime;
using TheWorld.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.PlatformAbstractions;

namespace TheWorld
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public Startup(IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

           
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<WorldContext>();

            services.AddScoped<IMailServices, DebugMailService>();

            services.AddMvc();

        }

        public void Configure(IApplicationBuilder app)
        {
            // Add the platform handler to the request pipeline.
            app.UseStaticFiles();
            app.UseMvc(config => {
                config.MapRoute(
                   name: "Default",
                   template: "{controller}/{action}/{id?}",
                   defaults: new { controller ="App", action = "Index"}
                   );
            });

        }
    }
}
