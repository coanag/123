using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solis_MVC.Startup))]
namespace Solis_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
