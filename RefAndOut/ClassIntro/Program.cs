namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Anonym Object
            //string name = "Riad";
            //string surname = "Hemidov";
            //byte age = 17;
            //string groupName = "AB204";

            //string name1 = "Cavid";
            //string surname1 = "Suleymanli";
            //byte age1 = 19;
            //string groupName1 = "AB204";

            //Console.WriteLine(name + " " + surname);
            //Console.WriteLine(name1 + " " + surname1);

            //string[] names = { "Mehriban", "Besti", "Araz", "Almaye", "Eli", "Lale" };
            //string[] surnames = { "Seferova", "Camalli", "Hummetov", "Memmedli", "Memmedov", "Gulehmedova" };


            //for (int i = 0; i < names.Length; i++)
            //{
            //    //Console.WriteLine(names[i] + " - " + surnames[i]);
            //    Console.WriteLine($"{names[i]} - {surnames[i]}");
            //}


            // anonym object
            //var student = new
            //{
            //    Name = "Zaman",
            //    Surname = "Seferov",
            //    Age = 19
            //};

            //var student1 = new
            //{
            //    Name = "Efsane",
            //    Surname = "Ehmedova",
            //    Age = 20,
            //    GroupName = "AB204"
            //};
            #endregion
            int[] arr = new int[] { };
            Student student = new Student();
            student.Name = "Test";
            student.Surname = "Test";
            student.Age = 1;
            student.GroupName = "Test";

            Student student1 = new Student();
            student1.Name = "Test1";
            student1.Surname = "Test1";
            student1.Age = 1;
            student1.GroupName = "Test1";

            Teacher teacher = new Teacher();
            teacher.Name = "Test";
            teacher.Surname = "Test";
            teacher.Age = 19;
            teacher.Salary = 1;
        }
    }

    public class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string GroupName;
    }

    public class Teacher
    {
        public string Name;
        public string Surname;
        public byte Age;
        public double Salary;
    }

    public class Desk
    {
        public int Height;
        public int Width;
        public string Color;
        public string Brand;
        public string Model;
    }

    public class Product
    {

    }
}