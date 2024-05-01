using AB204ConsoleApp.DAL;
using AB204ConsoleApp.Models;
using AB204ConsoleApp.Repositories.Abstracts;

namespace AB204ConsoleApp.Repositories.Concretes
{
    public class BlogRepository : IBlogRepository
    {
        public void Add(Blog blog)
        {
            AppDbContext.Blogs.Add(blog);
        }

        public void Delete(Blog blog)
        {
            AppDbContext.Blogs.Remove(blog);
        }

        public Blog Get(Predicate<Blog>? predicate)
        {
            return predicate == null ?
                    AppDbContext.Blogs.Find(x => true) :
                    AppDbContext.Blogs.Find(predicate);
        }

        public List<Blog> GetAll(Predicate<Blog>? predicate)
        {
            return predicate == null ?
                    AppDbContext.Blogs :
                    AppDbContext.Blogs.FindAll(predicate);
        }
    }
}
