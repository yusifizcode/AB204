using AB204ConsoleApp.Controllers;

namespace AB204ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlogController blogController = new BlogController();
            blogController.AddBlogFromUser();
        }
    }
}