namespace Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("name", "surname", 12, 32, 12);

            //student.Point = 87;

            //Student student1 = new Student();
            //student1.Name = "salam";


            //Human human = new Human("filankes", "filankesov", 23);

            Console.WriteLine($"{student.Name} - {student.Surname} - {student.Age}");

            //Console.WriteLine(student.GetFullInfo());
            //Console.WriteLine(student1.GetFullInfo());

        }
    }
}