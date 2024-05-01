using AB204ConsoleApp.Models;

namespace AB204ConsoleApp.Repositories.Abstracts
{
    public interface IBlogRepository
    {
        void Add(Blog blog);
        void Delete(Blog blog);
        Blog Get(Predicate<Blog>? predicate);
        List<Blog> GetAll(Predicate<Blog>? predicate);
    }
}
