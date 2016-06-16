using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using sas_Futura.Providers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace sas_Futura
{
    public class WebApiApplication : System.Web.HttpApplication
    {
       
      
        protected void Application_Start(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
   
          
           
        }

      }
}
