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
    }
}
