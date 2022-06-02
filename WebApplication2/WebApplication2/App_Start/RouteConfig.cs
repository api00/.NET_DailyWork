using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            

                    routes.MapRoute(
            name: "sample",
            url: "{controller}/{action}",
           new { controller = "Login", action = "LoginForm" }
);

        }
    }
}
