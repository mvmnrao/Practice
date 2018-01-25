using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppServiceSample.Startup))]
namespace AppServiceSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
