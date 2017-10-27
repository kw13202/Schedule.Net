using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace ScheduleConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(TestJob);

            if (type.IsClass && typeof(IJob).IsAssignableFrom(type))
            {
                Console.WriteLine("表示继承了IJob的类");
            }
            JobDataMap map = new JobDataMap();
            map.Add("name", "wr");
            map.Add("age", 18);

            IJobDetail job = JobBuilder
                .Create()
                .OfType(type)
                .WithDescription("Description")
                .WithIdentity(new JobKey("test1", "group1"))
                .UsingJobData(map)
                .Build();

            //var build = SimpleScheduleBuilder.Create();
            //if (true)
            //{
            //    build.WithIntervalInMinutes(1);
            //}
            //if (true)
            //{
            //    build.WithRepeatCount(5);
            //}
            var build = CronScheduleBuilder.CronSchedule("0 * * ? * * *");
            ITrigger trigger = TriggerBuilder
                .Create()
                .WithIdentity("trigger1", "group1")
                //.WithSimpleSchedule(x => x.WithIntervalInMinutes(1).RepeatForever())
                .WithSchedule(build)
                .ForJob(job)
                .Build();

            IScheduler sched = new StdSchedulerFactory().GetScheduler();
            sched.ScheduleJob(job, trigger);
            sched.Start();

            Console.ReadKey();
        }
    }
}
