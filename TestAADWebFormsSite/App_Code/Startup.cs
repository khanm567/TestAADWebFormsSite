using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAADWebFormsSite.Startup))]
namespace TestAADWebFormsSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
