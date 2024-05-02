using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using System.Data;

namespace Data.RepositoryConcretes
{
    public class StudentRepository : IStudentRepository
    {
        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Student Get(string command) // select * from Students where Id = 10
        {
            var dt = _appDbContext.Query(command);
            Student student = null;
            foreach (DataRow item in dt.Rows)
            {
                student = new Student
                {
                    Id = int.Parse(item[0].ToString()),
                    Fullname = item[1].ToString(),
                    Grant = decimal.Parse(item[2].ToString())
                };
            }

            return student;
        }

        public List<Student> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Student> students = new List<Student>();

            foreach (DataRow item in dt.Rows)
            {
                Student student = new Student
                {
                    Id = int.Parse(item[0].ToString()),
                    Fullname = item[1].ToString(),
                    Grant = decimal.Parse(item[2].ToString())
                };

                students.Add(student);
            }

            return students;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
