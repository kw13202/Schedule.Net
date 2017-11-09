using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.API
{
    [ServiceContract]
    public interface IServerManage
    {
        [OperationContract]
        void Test();
    }
}
