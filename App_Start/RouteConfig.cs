﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UserMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "Default",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );

            routes.MapRoute(
                name: "Users",
                url: "Users/Details",
                defaults: new { controller = "Users", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Role",
                url: "Role/Details",
                defaults: new { controller = "Role", action = "Details", id = UrlParameter.Optional }
            );
        }
    }
}
