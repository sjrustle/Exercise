using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yleana.Startup))]
namespace Yleana
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
