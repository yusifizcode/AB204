using AbstractionsPartTwo.Interfaces;

namespace AbstractionsPartTwo
{
    internal class Bear : Animal, IMammal, IWild, IRunable
    {
        public void Destroy()
        {
            Console.WriteLine("Destroyy!!");
        }

        public void IsMammal()
        {
            Console.WriteLine("Yes is mammal!");
        }

        public void Run()
        {
            Console.WriteLine("Runn!");
        }
    }
}
