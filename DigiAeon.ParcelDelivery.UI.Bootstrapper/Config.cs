using DigiAeon.ParcelDelivery.UI.Services.Interfaces;
using System.Configuration;

namespace DigiAeon.ParcelDelivery.UI.Bootstrapper
{
    public class Config : IConfig
    {
        public string SiteHeader
        {
            get
            {
                return ConfigurationManager.AppSettings["SiteHeader"];
            }
        }
    }
}
