using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.HomeModel model = new Models.HomeModel();
            model.TdList = new List<Models.ToDoItem>();

            Models.ToDoItem task1 = new Models.ToDoItem("Go to store", "Need to go to the store and pick up some groceries", 1);
            Models.ToDoItem task2 = new Models.ToDoItem("Clean up leaves", "Clean up the leaves in the yard and place then in bags", 2);
            Models.ToDoItem task3 = new Models.ToDoItem("Mow the lawn", "After cleaning up the leaves, mow the lawn", 3);

            model.TdList.Add(task1);
            model.TdList.Add(task2);
            model.TdList.Add(task3);

            return View(model);
        }
    }
}