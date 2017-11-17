using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.API;

namespace Server.Svr
{
    public class ServiceDAL
    {
        public List<TaskDetail> GetAllList()
        {
            using (ServiceDbContext db = new ServiceDbContext())
            {
                return db.TaskDetails.AsNoTracking().ToList();
            }
        }

    }
}
