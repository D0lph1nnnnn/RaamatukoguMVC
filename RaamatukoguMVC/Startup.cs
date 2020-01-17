using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaamatukoguMVC.Startup))]
namespace RaamatukoguMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
