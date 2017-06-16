using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eLoaner.Web.Startup))]
namespace eLoaner.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
