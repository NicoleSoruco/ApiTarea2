using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apitarea2.Startup))]
namespace Apitarea2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
