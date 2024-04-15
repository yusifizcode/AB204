using Core.Interfaces;

namespace Core.Models
{
    public class Car : Vehicle, IOilPowered
    {
        public override void Drive()
        {
            Millage += 10;
        }

        public void UseOil()
        {
            Console.WriteLine("Using Oil!!");
        }
    }
}
