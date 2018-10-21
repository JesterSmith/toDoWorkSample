using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class HomeModel
    {
        private List<ToDoItem> tdList;

        public List<ToDoItem> TdList { get => tdList; set => tdList = value; }
    }

    public class ToDoItem
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public Boolean Completed { get; set; }

        public ToDoItem(string title, string description, int priority)
        {
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.Completed = false;
        }

    }
}