using Core.Models;

namespace AccessModifiersPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "Test";
            //student.Surname = "Test";
            //student.Age = 1;
            //student.SetGrade();
            //Console.WriteLine(student.Grade);
            //Human human = new Human();


            Employee employee = new Employee();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee1.Id);
            Console.WriteLine(employee2.Id);
            Console.WriteLine(employee3.Id);
            Console.WriteLine(employee4.Id);
            Console.WriteLine(employee5.Id);

        }



    }



    //class Test : Human
    //{
    //    public void ShowTest()
    //    {
    //        Console.WriteLine($"{FractionCount}");
    //    }
    //}
}