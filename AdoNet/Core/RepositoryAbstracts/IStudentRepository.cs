using Core.Models;

namespace Core.RepositoryAbstracts
{
    public interface IStudentRepository
    {
        void Add(string command);
        void Delete(string command);
        void Update(string command);
        Student Get(string command);
        List<Student> GetAll(string command);
    }
}
