namespace Core.Models
{
    public class Student : Human
    {
        readonly int Grade = 5;
        //public int Grade { get; }


        public Student()
        {
            Grade = 0;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {FractionCount}");
        }


        public void SetGrade()
        {
            //Grade = 5;
        }
    }
}
