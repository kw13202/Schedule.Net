using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using DotNet.Helper;

namespace Server.Client
{
    public class ClientHelper<T> where T : class
    {
        private static readonly object locker = new object();
        private ChannelFactory<T> _factory;
        private T _curChannel;
        private MethodInfo _testAction;
        System.Timers.Timer t;
        public T GetService()
        {
            return _curChannel;
        }

        private void DoTest()
        {
            _testAction.Invoke(_curChannel, null);
        }

        public bool Initialize(string testActionFromT)
        {
            try
            {
                if (_factory == null)
                {
                    if (!WcfHelper.GetIPAndPort(typeof(T), out string ip, out int port))
                    {
                        return false;
                    }
                    _testAction = typeof(T).GetMethod(testActionFromT);
                    if (_testAction == null)
                    {
                        return false;
                    }
                    EndpointAddress serverAddress = new EndpointAddress(WcfHelper.GetSvrUri(typeof(T), ip, port));
                    _factory = new ChannelFactory<T>(WcfHelper.DefaultBinding, serverAddress);
                }
                lock (locker)
                {
                    _curChannel = _factory.CreateChannel();
                    DoTest();
                }
                if (t == null)
                {
                    t = new System.Timers.Timer(WcfHelper.ChkInterval);
                    t.Elapsed += new ElapsedEventHandler((obj, e) =>
                    {
                        try
                        {
                            DoTest();
                        }
                        catch
                        {
                            try
                            {
                                lock (locker)
                                {
                                    _curChannel = _factory.CreateChannel();
                                    DoTest();
                                }
                            }
                            catch
                            {
                                //do nothing,wait next check
                            }
                        }
                    });
                    t.Start();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log4netHelper.Log.WriteError("WCF服务初始化异常", ex);
                return false;
            }
        }
    }
}
