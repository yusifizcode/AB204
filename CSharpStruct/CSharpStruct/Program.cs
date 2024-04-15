namespace CSharpStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Sirac", "Huseynov");
            Console.WriteLine(student.Name);
            ChangeName(ref student);
            Console.WriteLine(student.Name);
        }

        static void ChangeName(ref Student student)
        {
            student.Name = "Test";
        }
    }
}