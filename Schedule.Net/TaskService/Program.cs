using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Svr;
using Topshelf;

namespace TaskService
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<ServiceDbContext>(new DataBase());
            //var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            //XmlConfigurator.ConfigureAndWatch(logCfg);

            HostFactory.Run(x =>
            {
                x.Service<MainService>(s =>
                {
                    s.ConstructUsing(name => new MainService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                //本地系统运行
                x.RunAsLocalSystem();
                //延迟启动
                x.StartAutomaticallyDelayed();

                //服务描述
                x.SetDescription("TaskService任务调度服务");
                //显示名称
                x.SetDisplayName("TaskService");
                //服务名称
                x.SetServiceName("TaskService");
            });
        }
    }
}
