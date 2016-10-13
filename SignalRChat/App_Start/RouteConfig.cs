using System.Web.Mvc;
using System.Web.Routing;

namespace SignalRChat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            routes.Ignore("signalr/hubs");
            routes.Ignore("fonts");
        }
    }
}