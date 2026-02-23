using ToDoList.Common;
using ToDoList.Data;

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
                Console.WriteLine("3.Complete Task");
                Console.WriteLine("4.Exit");

                var Choice = Console.ReadLine();

                switch (Choice) {
                    case "1":
                        Console.WriteLine("Enter Title");
                        var title = Console.ReadLine();
                        service.AddTask(title);
                        break;
                    case "2":
                        service.ViewTasks();
                        break;
                    case "3":
                        Console.WriteLine("Enter Task Id:");
                        int id = int.Parse(Console.ReadLine());
                        service.CompleteTask(id);
                        break;
                    case "4":
                        return;
                }
            }
        }
    }
}