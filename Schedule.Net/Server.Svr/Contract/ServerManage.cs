using System;
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
        private readonly ServiceDAL serviceDAL = new ServiceDAL();

        public void Test()
        {
#if DEBUG
            Log4netHelper.Log.WriteInfo("[IServerManage]Someone Testing Connection!");
#endif
        }

        /// <inheritdoc />
        /// <summary>
        /// 获取所有任务
        /// </summary>
        /// <returns></returns>
        public List<TaskDetail> GetAllList()
        {
            return serviceDAL.GetAllList();
        }

        /// <inheritdoc />
        /// <summary>
        /// 新增任务
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddTaskDetail(TaskDetail model)
        {
            if (model == null)
                return false;

            var entity = serviceDAL.AddTaskDetail(model);
            return entity.Id > 0;
        }

        /// <inheritdoc />
        /// <summary>
        /// 修改任务
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool EditTaskDetail(TaskDetail model)
        {
            if (model == null)
                return false;

            return serviceDAL.EditTaskDetail(model);
        }

        /// <inheritdoc />
        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelTaskDetail(int id)
        {
            return serviceDAL.DelTaskDetail(id);
        }

        /// <inheritdoc />
        /// <summary>
        /// 开始任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool StartTask(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool StopTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}
