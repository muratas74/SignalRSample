using System.Web.Mvc;
using System.Web.Routing;

namespace SignalRChat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
        }
    }
}