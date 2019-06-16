using pvptv2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace pvptv2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<DataContext>(null);
            //SqlDependency.Start(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
            //Start Sql dependecy to track db changes
            //SqlDependency.Start(@"data Source = .\SQLEXPRESS;initial Catalog = pvptv2;");
        }

        //protected void Acpplication_End()
        //{
        //    SqlDependency.Stop(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
        //}
    }
}
