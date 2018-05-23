using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevopsDemoApplication.Startup))]
namespace DevopsDemoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
