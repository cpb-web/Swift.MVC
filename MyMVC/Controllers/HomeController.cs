using Swift.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            HttpContext.Current.Response.Write("Hello MVC");
        }
    }
}