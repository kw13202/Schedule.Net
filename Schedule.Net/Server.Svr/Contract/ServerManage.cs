﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DotNet.Helper;
using Server.API;

namespace Server.Svr
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ServerManage : IServerManage
    {
        public void Test()
        {
#if DEBUG
            Log4netHelper.Log.WriteInfo("[IServerManage]Someone Testing Connection!");
#endif
        }
    }
}
