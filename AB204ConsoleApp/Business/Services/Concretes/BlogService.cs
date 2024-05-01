using AB204ConsoleApp.Models;
using AB204ConsoleApp.Repositories.Abstracts;
using AB204ConsoleApp.Repositories.Concretes;
using AB204ConsoleApp.Services.Abstracts;

namespace AB204ConsoleApp.Services.Concretes
{
    public class BlogService : IBlogService
    {
        IBlogRepository _blogRepository = new BlogRepository();
        public void AddBlog(Blog blog)
        {
            _blogRepository.Add(blog);
        }

        public void DeleteBlog(int id)
        {
            var blog = _blogRepository.Get(x => x.Id == id);
            if (blog == null) throw new NullReferenceException();

            _blogRepository.Delete(blog);
        }

        public List<Blog> GetAllBlogs(Predicate<Blog>? predicate)
        {
            //if(predicate == null)
            //{
            //    return AppDbContext.Blogs;
            //}
            //else
            //{
            //    return AppDbContext.Blogs.FindAll(predicate);
            //}

            return _blogRepository.GetAll(predicate);
        }

        public Blog GetBlog(Predicate<Blog>? predicate)
        {
            return _blogRepository.Get(predicate);
        }

        public void UpdateBlog(int id, Blog newBlog)
        {
            if (newBlog == null) throw new NullReferenceException();
            var oldBlog = _blogRepository.Get(x => x.Id == id);
            if (oldBlog == null) throw new NullReferenceException();

            oldBlog.Title = newBlog.Title;
            oldBlog.Description = newBlog.Description;
        }
    }
}
