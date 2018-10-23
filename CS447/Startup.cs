using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS447.Startup))]
namespace CS447
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
