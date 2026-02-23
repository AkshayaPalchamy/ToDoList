namespace ToDoList.Data
{
    //Encapsulation
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public bool IsCompleted { get; set; }

        public ToDoItem(int id,string title) 
        {
            Id=id;
            Title=title;
            IsCompleted=false;
        }

        public void MarkCompleted()
        {
            IsCompleted=true;
        }
    }
}
