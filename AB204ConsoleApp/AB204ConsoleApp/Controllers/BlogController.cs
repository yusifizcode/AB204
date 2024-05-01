using AB204ConsoleApp.Models;
using AB204ConsoleApp.Services.Abstracts;
using AB204ConsoleApp.Services.Concretes;

namespace AB204ConsoleApp.Controllers
{
    public class BlogController
    {
        IBlogService _blogService = new BlogService();

        public void AddBlogFromUser()
        {
            Console.WriteLine("Enter blog title: ");
            string blogName = Console.ReadLine();
            Console.WriteLine("Enter blog desc: ");
            string desc = Console.ReadLine();

            Blog blog = new Blog
            {
                Title = blogName,
                Description = desc
            };

            _blogService.AddBlog(blog);
        }
    }
}
