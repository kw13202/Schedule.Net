using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.API;

namespace Server.Client
{
    public class Service : IService<IServerManage>
    {
        protected override string GetTestActionName()
        {
            return "Test";
        }

        public void Test()
        {
            MyService.Test();
            Console.WriteLine("Test");
        }

        public List<TaskDetail> GetAllList()
        {
            return MyService.GetAllList();
        }


        public bool AddTaskDetail(TaskDetail model)
        {
            return MyService.AddTaskDetail(model);
        }

        public bool DelTaskDetail(int id)
        {
            return MyService.DelTaskDetail(id);
        }

        public bool EditTaskDetail(TaskDetail model)
        {
            return MyService.EditTaskDetail(model);
        }

    }
}
