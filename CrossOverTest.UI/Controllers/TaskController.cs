using CrossOverTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossOverTest.UI.Controllers
{
    public class TaskController : Controller
    {
        //
        // GET: /Task/
        public ActionResult Index()
        {
            return View();
        }

        private TaskService _taskService;

        private TaskService TaskService { get { return _taskService ?? new TaskService(); } }

        public JsonResult GetTasks()
        {
            var tasks = TaskService.GetTasks();

            return Json(tasks, JsonRequestBehavior.AllowGet);
        }
    }
}