using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Models.ToDoModel model = (Models.ToDoModel)Session["ToDoList"];
            if (model == null)
            {
                model = new Models.ToDoModel();

                Models.ToDoItem task1 = new Models.ToDoItem(1001, "Go to store", "Need to go to the store and pick up some groceries", 1);
                Models.ToDoItem task2 = new Models.ToDoItem(1002, "Clean up leaves", "Clean up the leaves in the yard and place then in bags", 2);
                Models.ToDoItem task3 = new Models.ToDoItem(1003, "Mow the lawn", "After cleaning up the leaves, mow the lawn", 3);

                model.Add(task1);
                model.Add(task2);
                model.Add(task3);
                
            }

            Session["ToDoList"] = model;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Models.ToDoModel viewModel)
        {
            Models.ToDoModel curModel = (Models.ToDoModel)Session["ToDoList"];

                Models.ToDoItem task = curModel.TaskList.Where(x => x.Key == Convert.ToInt32(Request.Form.Keys[0])).FirstOrDefault().Value;

                TempData["Task"] = task;

                return RedirectToAction("Index", "Update");
        }
    }
}