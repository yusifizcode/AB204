namespace ClassWork
{
    internal class Human
    {
        public Human()
        {

        }

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
            Age = age;
        }

        public byte Age;
        public string Name;
        public string Surname;


        public void ShowFullData()
        {
            Console.WriteLine(GetFullData());
        }

        public string GetFullData()
        {
            return $"{this.Name} {this.Surname}, Age: {this.Age}";
        }
    }
}
