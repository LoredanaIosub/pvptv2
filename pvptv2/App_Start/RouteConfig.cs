using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pvptv2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //Route to ignore

            routes.MapRoute(
                name: "Default", //Route name
                url: "{controller}/{action}/{id}", //URL Pattern
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } //Defaults for Route
            );
        }
    }
}
