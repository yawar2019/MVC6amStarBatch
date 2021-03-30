using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC6amStarBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("New/Index");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default1",
                url: "wednesday/party",
                defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "New", action = "Index", id = UrlParameter.Optional }
          );
        }
    }
}
