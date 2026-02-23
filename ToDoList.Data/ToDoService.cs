using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Common;
//Polymorphism
namespace ToDoList.Data
{
    public class ToDoService:IToDoService
    {
        private List<ToDoItem> _tasks = new List<ToDoItem>();
        private int _id = 1;


        public void AddTask(string title)
        {
            var task = new ToDoItem(_id++, title);
            _tasks.Add(task);
        }

        public void ViewTasks()
        {
            foreach (var task in _tasks)
            {
                Console.WriteLine($"{task.Id}  {task.Title}  {(task.IsCompleted ? "Done" : "Pending")}");
            }
        }

        public void CompleteTask(int id) 
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == id) 
                {
                    _tasks[i].MarkCompleted();
                    break;
                }
            }
        }
    }
}
