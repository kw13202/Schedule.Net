using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DotNet.Helper;

namespace Server.Core
{
    /// <summary>
    /// WCF服务托管类
    /// </summary>
    public class HostHelper<T, K> where K : class, T, new()
    {

        private ServiceHost _service;
        private Uri _urlService = null;

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initialize()
        {
            if (WcfHelper.GetIPAndPort(typeof(T), out string ip, out int port))
            {
                _urlService = WcfHelper.GetSvrUri(typeof(T), ip, port);
                OpenService();
            }
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        private void OpenService()
        {
            _service = new ServiceHost(new K(), _urlService);
            _service.AddServiceEndpoint(typeof(T), WcfHelper.DefaultBinding, _urlService);
            _service.Open();

            string serviceInfo = string.Format("Service[{0}] Start Success!{2}ServiceURL:[{1}]", typeof(T).Name, _urlService.ToString(), Environment.NewLine);
            Log4netHelper.Log.WriteInfo(serviceInfo);
        }

    }
}
