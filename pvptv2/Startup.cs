using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;



[assembly: OwinStartupAttribute(typeof(pvptv2.Startup))]
namespace pvptv2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            app.MapSignalR();
        }

        //private void ConfigureAuth(IAppBuilder app)
        //{
        //    throw new NotImplementedException();
        //}
    }
}