using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Video
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;

            routes.IgnoreRoute("Scripts/{all}");
            routes.IgnoreRoute("Content/{all}");
            //routes.IgnoreRoute("Video/{all}");

            routes.MapRoute(
                name: "Video",
                url: "{controller}/{action}",
                defaults: new { controller = "Video", action = "Index" }
            );
        }
    }
}
