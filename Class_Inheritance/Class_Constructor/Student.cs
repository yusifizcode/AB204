namespace Class_Constructor
{
    internal class Student : Human
    {
        //public Student()
        //{

        //}

        //public Student(int point = 50)
        //{
        //    Point = point;
        //}

        //public Student(int point, int grant) : this(point)
        //{
        //    Grant = grant;
        //}

        public Student(string name, string surname, byte age, int point, int grant) : base(name, surname, age)
        {
            Console.WriteLine("Student created!");

            Point = point;
            Grant = grant;
        }

        public double Grant;
        public int Point;

        public string GetFullInfo()
        {
            return $"{this.Name} - {this.Surname} - {this.Age} - {this.Point} - {this.Grant}";
        }
    }
}
