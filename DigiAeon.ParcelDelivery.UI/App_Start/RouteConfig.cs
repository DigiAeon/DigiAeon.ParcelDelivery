using DigiAeon.ParcelDelivery.UI.Controllers;
using System.Web.Mvc;
using System.Web.Routing;

namespace DigiAeon.ParcelDelivery.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = DeliveryCostControllerConstants.ControllerName, action = DeliveryCostControllerConstants.CalculateAction, id = UrlParameter.Optional }
            );
        }
    }
}
