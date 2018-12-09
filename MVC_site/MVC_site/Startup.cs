using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_site.Startup))]
namespace MVC_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
