using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNet.Helper;
using Server.API;
using Topshelf;
using Server.Core;
using Server.Svr;

namespace TaskService
{
    public class MainService
    {
        public void Start()
        {
            Log4netHelper.Log.WriteInfo($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 启动服务");
            try
            {
                HostHelper<IServerManage, ServerManage> serverSvr = new HostHelper<IServerManage, ServerManage>();
                serverSvr.Initialize();
            }
            catch (Exception ex)
            {
                Log4netHelper.Log.WriteError("服务开启失败", ex);
            }
        }

        public void Stop()
        {
            Log4netHelper.Log.WriteInfo($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 停止服务");
        }

        public void Pause()
        {
            Log4netHelper.Log.WriteInfo($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 暂停服务");
        }

        public void Continue()
        {
            Log4netHelper.Log.WriteInfo($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 继续服务");
        }

        public void Shutdown()
        {
            Log4netHelper.Log.WriteInfo($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} Shutdown服务");
        }

    }
}
