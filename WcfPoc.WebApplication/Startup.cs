using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WcfPoc.WebApplication.Startup))]
namespace WcfPoc.WebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
