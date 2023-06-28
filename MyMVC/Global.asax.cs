using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Swift.MVC;

namespace MyMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteTable.Routes.Add(
                "defaultRoute", 
                new Route("{controller}/{action}/{id}", 
                new RouteValueDictionary(new { controller = "Home", action = "Index", id = "", namespaces = "MyMVC.Controllers", assembly = "MyMVC" }), 
                new Swift.MVC.MvcRouteHandler()));
        }
    }
}
