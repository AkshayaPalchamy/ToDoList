using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using ToDoList.Common;
using ToDoList.Data;

namespace ToDoList.Logic
{
    public class ToDoService: IToDoService
    {
        private int _id = 1;

        private bool HasViewed = false;
        private string _filePath = "tasks.json";

        private List<ToDoItem> _tasks;
       

        public ToDoService()
        {
            _tasks = new List<ToDoItem>();
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                _tasks = JsonSerializer.Deserialize<List<ToDoItem>>(json);/*?? new List<ToDoItem>()*/; //if left side is null use right side

                if (_tasks.Count > 0)
                {
                    _id = _tasks.Max(t => t.Id) + 1;
                }
            }
        }

        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(_tasks);
            File.WriteAllText(_filePath, json);
        }

        public void AddTask(string title)
        {
            var task = new ToDoItem(_id++, title);
            _tasks.Add(task);
            SaveToFile();
        }

        public void ViewTasks()
        {
            foreach (var task in _tasks)
            {
                Console.WriteLine($"{task.Id} | {task.Title} | {(task.IsCompleted ? "Done" : "Pending")}");
                Console.WriteLine("---------------------------------------------------------");
            }

            HasViewed = true;
        }

        public void CompleteTask(int id)
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == id)
                {
                    _tasks[i].MarkCompleted();
                    SaveToFile();
                    break;
                }
            }
        }

        public void UpdateTask(int id, string? newtitle)
        {
            if (!HasViewed)
            {
                Console.WriteLine("Please view the file before edit and deleting!");
                return;
            }
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == id)
                {
                    _tasks[i].Id = i;
                    _tasks[i].Title = newtitle;
                    SaveToFile();
                }
            }
        }

        public void DeleteTask(int id)
        {
            if (!HasViewed)
            {
                Console.WriteLine("Please view the file before edit and deleting!");
                return;
            }
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == id)
                {
                    _tasks.RemoveAt(i);
                }
            }
        }

    }
}
