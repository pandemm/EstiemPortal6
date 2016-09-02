using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstiemPortal6.Startup))]
namespace EstiemPortal6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
