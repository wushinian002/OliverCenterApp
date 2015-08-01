using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OliverCenterApp.Startup))]
namespace OliverCenterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
