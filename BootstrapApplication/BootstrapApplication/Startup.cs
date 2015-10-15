using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapApplication.Startup))]
namespace BootstrapApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
