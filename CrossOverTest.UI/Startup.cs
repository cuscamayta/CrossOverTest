using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrossOverTest.UI.Startup))]
namespace CrossOverTest.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
