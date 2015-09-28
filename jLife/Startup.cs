using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jLife.Startup))]
namespace jLife
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
