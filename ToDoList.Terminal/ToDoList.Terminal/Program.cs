using ToDoList.Common;
using ToDoList.Data;
using ToDoList.Logic;

namespace ToDoList.Terminal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IToDoService service = new ToDoService();

            while (true) 
            {
                Console.WriteLine("1.Add Task");
                Console.WriteLine("2.View Task");
                Console.WriteLine("3.Update Task");
                Console.WriteLine("4.Complete Task");
                Console.WriteLine("5.Delete Task");
                Console.WriteLine("6.Exit");

                var Choice = Console.ReadLine();

                switch (Choice) {
                    case "1":
                        Console.WriteLine("Enter Title:");
                        var title = Console.ReadLine();
                        service.AddTask(title);
                        break;
                    case "2":
                        service.ViewTasks();
                        break;
                    case "3":
                        Console.WriteLine("Enter Title:");
                        string Title = Console.ReadLine();
                        Console.WriteLine("Enter Id");
                        int id = int.Parse(Console.ReadLine());
                        service.UpdateTask(id,Title);
                        break;
                    case "4":
                        Console.WriteLine("Enter Task Id:");
                        int id1 = int.Parse(Console.ReadLine());
                        service.CompleteTask(id1);
                        break;
                    case "5":
                        Console.WriteLine("Enter Task Id:");
                        int id2 = int.Parse(Console.ReadLine());
                        service.DeleteTask(id2);
                        break;
                    case "6":
                        return;
                }
            }
        }
    }
}