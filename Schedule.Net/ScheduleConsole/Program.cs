using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Server.Client;

namespace ScheduleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //启动WCF服务
            while (!SvrFactory.Instance.Initialize())
            {
                Thread.Sleep(50);//这里必须等WCF连接上
            }
            SvrFactory.Instance.ServiceSvr.Test();
            Console.ReadKey();
        }
    }
}
