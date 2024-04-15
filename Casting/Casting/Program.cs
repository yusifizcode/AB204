namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // explicit & implicit conversion
            // boxing & unboxing
            // upcasting & downcasting


            //byte a = 43;
            //int num = a; // implicit conversion // int - 2milyard, byte - 0:255

            // int a = 1256;
            // byte b = (byte)a; // explicit conversion

            //int r = 123;
            //double c = 123.4;
            //int z = (int)c;

            //Console.WriteLine(z);


            //Human human = new Employee(); // upcasting

            //human.Name = "Test";
            //human.Surname = "Test123";


            Human human = new Human();
            Developer developer = new Developer();
            developer.Experience = 20;
            Manager manager = new Manager();
            manager.Salary = 123;
            //human = employee; // upcasting
            //manager = human as Manager; // downcasting with explicit operator

            Human[] humans = new Human[] { developer, manager };

            foreach (var item in humans)
            {
                //var dev = (Developer)item; // unable to cast
                //var dev = item as Developer; // = null
                //Console.WriteLine(dev.Experience);

                if (item is Developer dev)
                {
                    //var dev = item as Developer;
                    Console.WriteLine(dev.Experience);
                }
                else if (item is Manager man)
                {
                    //var man = item as Manager;
                    Console.WriteLine(man.Salary);
                }
            }

            //manager = (Developer)employee;


            int a = 234;

            object num = a; // boxing
            a = (int)num; // unboxing


            object num1 = null;
            num = num1;


            object[] arr = { "asd", 231, true };

            string b = (string)arr[1];
            Console.WriteLine(b);

        }


        //static void Sum(int? a, int b)
        //{
        //    if(a != null)
        //    {
        //        Console.WriteLine(a + b);
        //    }
        //}
    }


    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Developer : Human
    {
        public double Experience { get; set; }
    }

    class Manager : Human
    {
        public double Salary { get; set; }
    }



}