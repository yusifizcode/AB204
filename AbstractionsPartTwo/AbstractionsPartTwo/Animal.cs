using AbstractionsPartTwo.Interfaces;

namespace AbstractionsPartTwo
{
    internal abstract class Animal : IAnimal
    {
        public string Sort { get; set; }
        public bool Gender { get; set; }
        public int Speed { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating!");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping!");
        }
    }
}
