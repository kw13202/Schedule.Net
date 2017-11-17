using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.API
{
    /// <summary>
    /// 服务接口
    /// </summary>
    [ServiceContract]
    public interface IServerManage
    {
        /// <summary>
        /// 测试方法，检测是否联通
        /// </summary>
        [OperationContract]
        void Test();

        [OperationContract]
        List<TaskDetail> GetAllList();

    }
}
