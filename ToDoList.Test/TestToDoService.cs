using ToDoList.Data;
using ToDoList.Logic;

namespace ToDoList.Test
{
    [TestClass]
    public  class TestToDoService
    {
        ToDoService services = new ToDoService();

        [TestMethod]
        public void TestAddTask()
        {
           //Arrange
           string Title = "Title";
           string Description = "Description";
           int Id = 1;

           //Act
           services.AddTask(Title);

            //Assert
            Assert.AreEqual("Title", Title);
        }

        [TestMethod]
        public void TestViewTasks()
        {
            //Arrange
            string Title = "Title";
            string Description = "Description";
            int Id = 1;

            //Act
            services.ViewTasks();

            //Assert
        }

        [TestMethod]
        public void TestComplteTask()
        {
            //Arrange
            string Title = "Title";
            string Description = "Description";
            int Id = 1;
            services.AddTask("Title");

            //Act
            services.CompleteTask(1);

            //Assert
        }
    }
}
