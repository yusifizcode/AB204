using AbstractionsPartTwo.Interfaces;

namespace AbstractionsPartTwo
{
    internal class Eagle : Animal, IWild
    {
        public void Destroy()
        {
            Console.WriteLine("Eagle Destroy");
        }
    }
}
