using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using ToDoList.Common;
//Polymorphism
namespace ToDoList.Data
{
    public class DTO
    {
        public List<ToDoItem> _tasks = new List<ToDoItem>();
    }
}
