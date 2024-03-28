namespace ClassWork
{
    internal class Student : Human
    {
        public Student()
        {

        }
        public Student(string name, string surname, byte age, int point) : base(name, surname, age)
        {
            Point = point;
        }

        public double Point;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname}, Age: {Age} - {Point}");
        }
    }
}
