using AbstractionsPartTwo.Interfaces;

namespace AbstractionsPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Bear();
        }
    }
}