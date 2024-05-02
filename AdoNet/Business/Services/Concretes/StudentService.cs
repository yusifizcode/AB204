using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.RepositoryConcretes;

namespace Business.Services.Concretes
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository = new StudentRepository();
        public void AddStudent(Student student)
        {
            string command = $"Insert Into Students (Fullname, [Grant]) values ('{student.Fullname}',{student.Grant})";
            _studentRepository.Add(command);
        }

        public void DeleteStudent(int id)
        {
            string command = $"DELETE FROM Students WHERE Id = {id}";
            _studentRepository.Delete(command);
        }

        public List<Student> GetAllStudents()
        {
            string command = "SELECT * FROM Students";
            return _studentRepository.GetAll(command);
        }

        public Student GetStudent(int id)
        {
            string command = $"SELECT * FROM Students WHERE Id = {id}";
            return _studentRepository.Get(command);
        }

        public void UpdateStudent(int id, Student newStudent)
        {
            string command = $"SELECT * FROM Students WHERE Id = {id}";
            Student student = _studentRepository.Get(command);

            if (student == null) throw new NullReferenceException();

            student.Fullname = newStudent.Fullname;
            student.Grant = newStudent.Grant;

            string updateCommand = $"UPDATE Students SET Fullname = '{student.Fullname}', [Grant] = {student.Grant} WHERE Id = {id}";
            _studentRepository.Update(updateCommand);
        }
    }
}
