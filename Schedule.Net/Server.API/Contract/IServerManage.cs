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

        /// <summary>
        /// 获取全部任务
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<TaskDetail> GetAllList();

        /// <summary>
        /// 新增任务
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddTaskDetail(TaskDetail model);

        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [OperationContract]
        bool EditTaskDetail(TaskDetail model);

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool DelTaskDetail(int id);

        /// <summary>
        /// 开始任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool StartTask(int id);

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool StopTask(int id);

    }
}
