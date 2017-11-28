using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Server.Client;

namespace Schedule.Net
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //启动WCF服务
            while (!SvrFactory.Instance.Initialize())
            {
                Thread.Sleep(50);//这里必须等WCF连接上
            }
        }
    }
}
