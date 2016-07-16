using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalonbeautyWeb.Startup))]
namespace SalonbeautyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
