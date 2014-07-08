using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(norris.Startup))]
namespace norris
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
