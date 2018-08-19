using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.Controllers; // remember to import this name space so sub controller can be used, i.e. PostsController

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Gets each sub controller where the sub controllers of area definition  their namespace value
            // And then we can use it to distinguish the different project controller and area controller...
            var namespaces = new[ ] { typeof (PostsController).Namespace};

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);
        }
    }
}
