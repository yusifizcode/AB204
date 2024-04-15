namespace CSharp_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();

            //object[] arr = { student, "salam", true, 4, 5, 6 };

            //GetSomething();
            //int c = 3;
            //int sum = Sum(1, 2, out c);

            //Console.WriteLine(sum);
            //Console.WriteLine(c);

            //int week = 3;
            //string month = "January";
            //(int, string, bool) weekAndMonth = (week, month, true);
            //Console.WriteLine(weekAndMonth);
            //Console.WriteLine(GetSomething().Yazi);

            var tuple = GetTuple();

            (int Eded, string Yazi, bool HeYaYox) lorem = (1, "asd", true);
            (int YeneEded, string YeneYazi, bool YeneHeYaYox, Student Telebe, Test Test) ipsum = GetTuple();
            Console.WriteLine(ipsum.Telebe.Name);
        }


        public static (int, string, bool, Student, Test) GetTuple()
        {
            int a = 5;
            string b = "salam";
            bool c = true;
            Student student = new Student()
            {
                Name = "TEST"
            };

            Test test = new Test("test");

            return (a, b, c, student, test);
        }









        static CustomObj GetSomething()
        {
            int a = 1;
            string b = "salam";
            bool c = true;
            Student student = new Student();
            CustomObj customObj = new CustomObj
            {
                Eded = a,
                Yazi = b,
                Boolean = c,
                Telebe = student,
            };

            return customObj;
        }



        public static int Sum(int a, int b, out int c)
        {
            c = 0;
            return a + b;
        }




    }

    record Test(string Test2);
    class Student
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public string Description { get; set; }
    }

    class CustomObj
    {
        public int Eded;
        public string Yazi;
        public bool Boolean;
        public Student Telebe;
    }
}