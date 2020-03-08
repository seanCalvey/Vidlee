using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlee.Startup))]
namespace Vidlee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
