using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Topshelf;

namespace TaskService
{
    public class MainService
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(MainService));

        public void Start()
        {
            _log.Info($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 启动服务");
        }

        public void Stop()
        {
            _log.Info($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 停止服务");
        }

        public void Pause()
        {
            _log.Info($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 暂停服务");
        }

        public void Continue()
        {
            _log.Info($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 继续服务");
        }

        public void Shutdown()
        {
            _log.Info($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} Shutdown服务");
        }

    }
}
