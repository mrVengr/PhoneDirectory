using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PhoneDirectory
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_BeginRequest()
        {
            if (Request.Headers.AllKeys.Contains("Origin") && Request.HttpMethod == "OPTIONS")
            {
                Response.Flush();
            }
        }

        protected void Application_Start()
        {
            //PhoneContext db = new PhoneContext();
            //db.Members.Add(new Models.Member("Іван", "Іванов", "0971111111", "Київ", "asdfg@gmail.com"));
            //db.Members.Add(new Models.Member("Дмитро", "Петренко", "0971111222", "Київ", "ag@gmail.com"));
            //db.SaveChanges();
            //db.Dispose();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
