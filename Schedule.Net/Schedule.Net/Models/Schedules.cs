using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Schedule.Net.Models
{
    public class Schedules
    {
        public Schedules()
        {
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }

        public string StrCreateDate
        {
            get { return CreateDate.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.CurrentInfo); }
            private set { }
        }
    }
}