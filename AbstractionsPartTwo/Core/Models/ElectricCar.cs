using Core.Interfaces;

namespace Core.Models
{
    public class ElectricCar : Vehicle, IElectricPowered
    {
        public override void Drive()
        {
            Millage += 8;
        }

        public void UseElectric()
        {
            Console.WriteLine("Using Electric!");
        }
    }
}
