using AdoNet.Controllers;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();

            //studentController.AddStudent();
            studentController.DeleteStudent();


        }
    }
}
