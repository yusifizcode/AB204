namespace Class_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region References
            //Human human = new Human(); // 0x123
            //human.Name = "Test";
            //human.Surname = "Test";
            //human.Age = 12;

            //Human human1 = new Human // 0x345
            //{
            //    Name = "Elovset",
            //    Surname = "Elekberov",
            //    Age = 23
            //};

            //human = human1; //0x345

            //Human human2 = new Human() // 0x567
            //{
            //    Name = "Salam",
            //    Surname = "Salam123",
            //    Age = 23
            //};

            //human1 = human2; //0x567
            //Console.WriteLine(human.Name);  // 0x345
            //Console.WriteLine(human1.Name); // 0x567
            //Console.WriteLine(human2.Name); // 0x567
            #endregion

            //Worker worker = new Worker();
            //worker.Salary = 1;
            //worker.Experience = 1;
            //worker.Age = 1;
            //worker.Name = "salam";
            //worker.Surname = "sagol";

            //Human human = new Human();
            //human.Name = "Salam";
            //human.Surname = "Salam";
            //human.Age = 12;

            Developer developer = new Developer();
            developer.Name = "Sirac";
            developer.Surname = "Huseynov";
            developer.Age = 19;
            developer.Experience = 10;
            developer.Salary = 15000;
            developer.DevelopmentSkill = ".NET";

            Developer developer1 = new Developer();
            developer1.Name = "Nicat";
            developer1.Surname = "Cabbarov";
            developer1.Age = 21;
            developer1.Experience = 8;
            developer1.Salary = 15000;
            developer1.DevelopmentSkill = ".NET";

            Developer[] developers = { developer, developer1 };

            for (int i = 0; i < developers.Length; i++)
            {
                developers[i].ShowFullInfo();
                Console.WriteLine("--------------------");
            }

        }
    }

    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
    }

    class Worker : Human
    {
        public double Salary;
        public int Experience;
    }

    class Developer : Worker
    {
        public string DevelopmentSkill;

        public void ShowFullInfo()
        {
            Console.WriteLine($"Name - {this.Name}\n" +
                  $"Surname - {this.Surname}\n" +
                  $"Age - {this.Age}\n" +
                  $"Exp - {this.Experience}\n" +
                  $"Salary - {this.Salary}\n" +
                  $"Skill - {this.DevelopmentSkill}");
        }
    }
}