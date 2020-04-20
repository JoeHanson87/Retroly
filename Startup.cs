using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Retroly.Startup))]
namespace Retroly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
