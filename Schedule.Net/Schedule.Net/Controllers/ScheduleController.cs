using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Schedule.Net.Models;

namespace Schedule.Net.Controllers
{
    public class ScheduleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetList(int pageIndex, int pageSize)
        {
            List<Schedules> list = new List<Schedules>()
            {
                new Schedules(){ Id = 1, Name = "任务1" },
                new Schedules(){ Id = 2, Name = "任务2" },
                new Schedules(){ Id = 3, Name = "任务3" },
                new Schedules(){ Id = 4, Name = "任务4" },
                new Schedules(){ Id = 5, Name = "任务5" },
                new Schedules(){ Id = 6, Name = "任务6" },
                new Schedules(){ Id = 7, Name = "任务7" },
                new Schedules(){ Id = 8, Name = "任务8" },
                new Schedules(){ Id = 9, Name = "任务9" },
                new Schedules(){ Id = 10, Name = "任务10" },
                new Schedules(){ Id = 11, Name = "任务11" },
                new Schedules(){ Id = 12, Name = "任务12" },
                new Schedules(){ Id = 13, Name = "任务13" },
                new Schedules(){ Id = 14, Name = "任务14" },
                new Schedules(){ Id = 15, Name = "任务15" },
                new Schedules(){ Id = 16, Name = "任务16" },
                new Schedules(){ Id = 17, Name = "任务17" },
                new Schedules(){ Id = 18, Name = "任务18" },
                new Schedules(){ Id = 19, Name = "任务19" },
                new Schedules(){ Id = 20, Name = "任务20" },
            };
            var temp = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return Json(new ReturnData(0, "", list.Count, temp), JsonRequestBehavior.AllowGet);
        }
    }
}