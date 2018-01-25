using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompleteDISample.Startup))]
namespace CompleteDISample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
