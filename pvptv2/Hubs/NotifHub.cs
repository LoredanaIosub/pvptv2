using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pvptv2.Hubs
{
    public class NotifHub : Hub
    {
        public static void Send()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<NotifHub>();
            //context.Clients.All.displaypvptv2();
            context.Clients.All.displayStatus();
        }
    }
}