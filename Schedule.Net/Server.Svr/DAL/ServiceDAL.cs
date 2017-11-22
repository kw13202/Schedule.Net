using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using Server.API;

namespace Server.Svr
{
    public class ServiceDAL
    {

        public TaskDetail AddTaskDetail(TaskDetail model)
        {
            using (ServiceDbContext db = new ServiceDbContext())
            {
                var entity = db.TaskDetails.Add(model);
                db.SaveChanges();
                return entity;
            }
        }

        public bool DelTaskDetail(int id)
        {
            using (ServiceDbContext db = new ServiceDbContext())
            {
                int result = db.TaskDetails.Where(x => x.Id == id).Delete();
                return result > 0;
            }
        }

        public bool EditTaskDetail(TaskDetail model)
        {
            bool flag = false;
            using (ServiceDbContext db = new ServiceDbContext())
            {
                db.Entry<TaskDetail>(model).State = EntityState.Modified;
                db.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public List<TaskDetail> GetAllList()
        {
            using (ServiceDbContext db = new ServiceDbContext())
            {
                return db.TaskDetails.AsNoTracking().ToList();
            }
        }



    }
}
