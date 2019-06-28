using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Interview2.Startup))]
namespace Interview2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
