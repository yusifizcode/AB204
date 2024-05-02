using Core.Models;

namespace Business.Services.Abstracts
{
    public interface IStudentService
    {
        void DeleteStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(int id, Student newStudent);

        Student GetStudent(int id);
        List<Student> GetAllStudents();
    }
}
