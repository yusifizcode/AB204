namespace Record_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer()
            {
                Name = "Test",
                Surname = "Test",
                Skill = "Test",
            }; // 0x123

            //Console.WriteLine(developer);

            //developer.Surname = "Test";
            //developer.Skill = "Test";

            //Developer developer1 = new Developer(); // 0x345
            //developer1.Name = "Test";
            //developer1.Surname = "Test";
            //developer1.Skill = "Test";


            //Console.WriteLine(developer == developer1);

            //Manager manager = new Manager()
            //{
            //    Name = "test",
            //    Surname = "Test",
            //    Skill= "Test",
            //};
            //Manager manager1 = new Manager();
            //manager1.Name = "Test";
            //manager1.Surname = "Test";
            //manager1.Skill = "Test";

            //Console.WriteLine(manager == manager1);

            Test test = new Test("Anar", "Balacayev", ".NET");
            Console.WriteLine(test);


            Manager manager = new Manager()
            {
                Name = "Salam"
            };

            //HR hr = new HR()
            //{
            //    Test = "salkasdnal"
            //};

            manager = manager with
            {
                Name = "Test",
            };

            Console.WriteLine(manager);

            Human human = new Human()
            {
                Name = "Human",
                Surname = "Human",
                Skill = "Test",
            };

            HR hR = new HR()
            {
                Name = "Human",
                Surname = "Human",
                Skill = "Test",
            };

            human = hR with
            {

            };

            Manager manager1 = new Manager()
            {
                Name = "Lorem",
                Surname = "Test",
                Skill = "Test",
            };
        }
    }

    record Test(string Name, string Surname, string Skill);

    record HR : Human
    {
        public HR()
        {

        }

        public HR(string name, string surname)
        {

        }
    }

    record Human
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Skill { get; init; }
    }
}