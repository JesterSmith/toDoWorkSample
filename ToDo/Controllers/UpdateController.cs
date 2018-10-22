using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDo.Controllers
{
    public class UpdateController : Controller
    {
        public ActionResult Index()
        {
            Models.ToDoItem task = (Models.ToDoItem)TempData["Task"];

            return View("index", task);
        }

        [HttpPost]
        public ActionResult UpdateTask()
        {
            Models.ToDoModel model = (Models.ToDoModel)Session["ToDoList"];

            Models.ToDoItem curTask = model.TaskList.Values.Where(x => x.ID == Convert.ToInt32(Request.Form["ID"])).FirstOrDefault();

            Models.ToDoItem.Progress status;

            Enum.TryParse((Request.Form["Status"]), out status);

            curTask.UpdateTask(Request.Form["Title"], Request.Form["Description"], status);

            model.TaskList[Convert.ToInt32(Request.Form["ID"])] = curTask;

            Session["ToDoList"] = model;

            return RedirectToAction("Index", "Home");
        }
    }
}