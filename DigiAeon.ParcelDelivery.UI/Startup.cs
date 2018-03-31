using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigiAeon.ParcelDelivery.UI.Startup))]
namespace DigiAeon.ParcelDelivery.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
