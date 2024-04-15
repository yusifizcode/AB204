using Core.Interfaces;

namespace Core.Models
{
    public class Bycle : Vehicle, IActionPowered, IElectricPowered
    {
        public override void Drive()
        {
            Millage += 2;
        }

        public void UseAction()
        {
            Console.WriteLine("Action using!");
        }

        public void UseElectric()
        {
            Console.WriteLine("Bycle using electric!");
        }
    }
}
