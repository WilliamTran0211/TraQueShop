using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TraQueShop.Startup))]
namespace TraQueShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
