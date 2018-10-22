using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class ToDoModel
    {
        private Dictionary<int, ToDoItem> _taskList;

        public Dictionary<int, ToDoItem> TaskList { get; set; }

        public ToDoModel()
        {
            TaskList = new Dictionary<int, ToDoItem>();
        }

        public void Add(ToDoItem item)
        {
            TaskList.Add(item.ID, item);
        }

        public void Remove(ToDoItem item)
        {
            TaskList.Remove(item.ID);
        }
    }

    public class ToDoItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public Progress Status { get; set; }

        public enum Progress { Pending, Started, Done };

        public ToDoItem(int id, string title, string description, int priority)
        {
            this.ID = id;
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.Status = Progress.Pending;
        }

        public void UpdateTask(string title, string descrption, Progress status)
        {
            this.Title = title;
            this.Description = descrption;
            this.Status = status;
        }

    }
}