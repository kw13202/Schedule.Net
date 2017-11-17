using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.API
{
    /// <summary>
    /// 计划任务详情
    /// </summary>
    public class TaskDetail
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string JobName { get; set; }
        /// <summary>
        /// 任务组别
        /// </summary>
        public string JobGroup { get; set; }
        /// <summary>
        /// 任务描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 触发器名称
        /// </summary>
        public string TriggerName { get; set; }
        /// <summary>
        /// 触发器组别
        /// </summary>
        public string TriggerGroup { get; set; }
        /// <summary>
        /// 规则类型
        /// </summary>
        public Int16 RuleType { get; set; }
        /// <summary>
        /// 规则内容
        /// </summary>
        public string RuleText { get; set; }

    }
}
