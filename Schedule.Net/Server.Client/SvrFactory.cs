using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Client
{
    public class SvrFactory
    {
        #region 单例

        private static readonly object _locker = new object();
        private static SvrFactory _instance;
        public static SvrFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new SvrFactory();
                        }
                    }
                }
                return _instance;
            }

        }

        #endregion

        public bool Initialize()
        {
            bool res = true;
            res &= _serviceSvr.Initialize();
            return res;
        }

        private readonly Service _serviceSvr = new Service();
        public Service ServiceSvr
        {
            get
            {
                return _serviceSvr;
            }
        }

    }
}
