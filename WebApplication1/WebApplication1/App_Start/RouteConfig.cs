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
            //var house = new[ ] { typeof (PostsController).Namespace};
            var mainNamespace = new[] { typeof(AuthController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // It is similar to django urls.py where the syntax is sth like the following:
            // urls(r'^$',views.x,name='');
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, mainNamespace);
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, mainNamespace);
        }
    }
}
    