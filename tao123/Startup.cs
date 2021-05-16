using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tao123.Startup))]
namespace tao123
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
