namespace ToDoList.Common
{
    //Abstraction
    public interface IToDoService
    {
        void AddTask(string? Title); 
        void ViewTasks();
        void DeleteTask(int id);
        void UpdateTask(int id,string? Title);
        void CompleteTask(int Id);
    }
}
