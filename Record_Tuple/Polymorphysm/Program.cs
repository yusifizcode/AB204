namespace Polymorphysm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Developer();
            human.Name = "Eli";
            human.SurName = "Memmedov";
            human.Age = 30;

            human.ShowInfo();

            Developer developer = new Developer();
            developer.Name = "Nazeni";
            developer.SurName = "Mustafayeva";
            developer.Age = 30;
            developer.Experience = 10;
            developer.ShowInfo();

            Student student = new Student();
            student.Name = "Riad";
            student.SurName = "Hemidov";
            student.Age = 30;
            student.Grade = 10;
            student.ShowInfo();

            Human human1 = new Developer();
            human1.Name = "Test";
            human1.SurName = "Test";
            human1.Age = 30;
            human1.ShowInfo();
            human1.Calc(5, 3);
            //Developer developer = new Developer();
        }
    }


    class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {SurName}, Age: {Age}");
        }

        public virtual void Calc(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

    class Developer : Human
    {
        public int Experience { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {SurName}, Age: {Age}, Experience: {Experience}");
        }

        public override void Calc(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }

    class Student : Human
    {
        public int Grade { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {SurName}, Age: {Age}, Grade: {Grade}");
        }

        public override void Calc(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}