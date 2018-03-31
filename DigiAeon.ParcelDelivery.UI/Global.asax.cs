using DigiAeon.ParcelDelivery.UI.Bootstrapper;
using System.Web.Mvc;
using System.Web.Routing;

namespace DigiAeon.ParcelDelivery.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DependencyResolver.SetResolver(new ObjectDependencyResolver(new Config()));
        }
    }
}
