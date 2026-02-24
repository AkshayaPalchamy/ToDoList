namespace ToDoList.Common
{
    //Abstraction
    public interface IToDoService
    {
        void AddTask(string? Title); 
        void ViewTasks();
        void CompleteTask(int Id);
    }
}
