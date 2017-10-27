using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Schedule.Net.Models
{
    public class ReturnData
    {
        public ReturnData()
        {
            
        }
        public ReturnData(int code, string msg = "", object data = null)
        {
            this.code = code;
            this.msg = msg;
            this.data = data;
        }
        public ReturnData(int code, string msg = "", int count = 0, object data = null)
        {
            this.code = code;
            this.msg = msg;
            this.count = count;
            this.data = data;
        }
        public int code { get; set; } = 0;
        public string msg { get; set; }
        public int count { get; set; } = 0;
        public object data { get; set; }
    }
}