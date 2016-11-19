using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(taller2Razor.Startup))]
namespace taller2Razor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
