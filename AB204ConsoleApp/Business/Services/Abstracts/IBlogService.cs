using AB204ConsoleApp.Models;

namespace AB204ConsoleApp.Services.Abstracts
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void DeleteBlog(int id);
        void UpdateBlog(int id, Blog newBlog);
        Blog GetBlog(Predicate<Blog>? predicate);
        List<Blog> GetAllBlogs(Predicate<Blog>? predicate);
    }
}
