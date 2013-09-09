using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ProjectName.Common.Logger;
using ProjectName.Interfaces.Common;
using StructureMap;

namespace ProjectName.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {


        public void ConfigureStructureMap()
        {
            ObjectFactory.Configure(s => s.For<ILogger>().Use<FileLogger>());
        }


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureStructureMap();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            ILogger logger = ObjectFactory.GetInstance<ILogger>();
            logger.LogError(ex, HttpContext.Current.Request.Path);
            //Server.ClearError();
        }
    }
}