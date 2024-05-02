using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;

namespace AdoNet.Controllers
{
    public class StudentController
    {
        IStudentService _studentService = new StudentService();

        public void AddStudent()
        {
            Console.WriteLine("Enter student fullname: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter student grant: ");
            decimal grant = decimal.Parse(Console.ReadLine());

            Student student = new Student()
            {
                Fullname = fullName,
                Grant = grant
            };

            _studentService.AddStudent(student);
        }

        public void DeleteStudent()
        {
            Console.WriteLine("Enter student id: ");
            int id = int.Parse(Console.ReadLine());

            _studentService.DeleteStudent(id);
        }

        public void UpdateStudent()
        {
            GetAllStudents();
            Console.WriteLine("Enter student id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student fullname: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter student grant: ");
            decimal grant = decimal.Parse(Console.ReadLine());

            Student newStudent = new Student()
            {
                Fullname = fullName,
                Grant = grant
            };

            _studentService.UpdateStudent(id, newStudent);
        }

        public void GetAllStudents()
        {
            foreach (var item in _studentService.GetAllStudents())
            {
                Console.WriteLine($"{item.Id} - {item.Fullname} - {item.Grant}");
            }
        }

        public void GetStudent()
        {
            Console.WriteLine("Enter student id: ");
            int id = int.Parse(Console.ReadLine());

            Student student = _studentService.GetStudent(id);

            Console.WriteLine($"{student.Id} - {student.Fullname} - {student.Grant}");
        }

    }
}
