using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BB2OP.Web.Startup))]
namespace BB2OP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
