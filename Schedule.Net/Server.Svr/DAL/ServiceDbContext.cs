using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.API;

namespace Server.Svr
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext() : base("name=ServiceDbStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //EF 默认的schema 是dbo，但是PG默认是public，这里改一下
            modelBuilder.HasDefaultSchema("public");

            EntityTypeConfiguration<TaskDetail> taskDetailConfig = modelBuilder.Entity<TaskDetail>();
            taskDetailConfig.ToTable("TaskDetail");
            taskDetailConfig.HasKey(x => x.Id);
            taskDetailConfig.Property(x => x.JobName).HasMaxLength(50).IsRequired();
            taskDetailConfig.Property(x => x.JobGroup).HasMaxLength(50).IsRequired();
            taskDetailConfig.Property(x => x.TriggerName).HasMaxLength(50).IsRequired();
            taskDetailConfig.Property(x => x.TriggerGroup).HasMaxLength(50).IsRequired();
        }
        public virtual DbSet<TaskDetail> TaskDetails { get; set; }
    }
}
