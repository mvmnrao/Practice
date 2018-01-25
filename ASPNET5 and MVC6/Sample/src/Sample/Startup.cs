using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Framework.ConfigurationModel;
using Sample.Services;

namespace Sample
{
    public class Startup
    {
        public IConfiguration configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            //Configuration conf = new Configuration();
            var confB = new ConfigurationBuilder().AddJsonFile("config.json");
            //configuration = new Configuration().AddJsonFile("config.json").AddEnvironmentVariables();
            //conf.Set("message", "This message is from configuration object, not from file.");//.AddJsonFile("config.json");
            //IConfigurationSource source = ConfigurationSource
            //conf.Add()
            configuration = confB.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddInstance<IGreetingService>(new GreetingService(configuration));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            //app.UseIISPlatformHandler();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //app.UseMvc(routes => routes.MapRoute("default", "{controller=Home}/{action=Index}"));

            app.UseMvc();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
