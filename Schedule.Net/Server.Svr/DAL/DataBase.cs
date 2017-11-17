using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.API;

namespace Server.Svr
{
    public class DataBase : DropCreateDatabaseIfModelChanges<ServiceDbContext>
    {
        protected override void Seed(ServiceDbContext context)
        {
            context.TaskDetails.Add(new TaskDetail()
            {
                JobName = "Test1",
                JobGroup = "Test1",
                Description = "Test",
                TriggerName = "Trigger1",
                TriggerGroup = "Trigger1",
                RuleType = 2,
                RuleText = "0 * * ? * * *"
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
