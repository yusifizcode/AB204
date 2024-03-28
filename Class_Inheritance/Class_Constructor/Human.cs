namespace Class_Constructor
{
    internal class Human
    {

        public Human(string name)
        {
            Name = name;
        }

        public Human(string name, string surname) : this(name)
        {
            Surname = surname;
        }

        public Human(string name, string surname, byte age) : this(name, surname)
        {
            Console.WriteLine("Human created!");
            Age = age;
        }

        public string Name;
        public string Surname;
        public byte Age;
    }
}
