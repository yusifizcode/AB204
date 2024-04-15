using Core.Models;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bycle bycle = new Bycle();
            bycle.Color = "Red";
            bycle.Brand = "Rambo";
            bycle.Millage = 100;
            bycle.Drive();
            bycle.ShowInfo();
            bycle.UseAction();


            ElectricCar electricCar = new ElectricCar();
            electricCar.Color = "white";
            electricCar.Brand = "Tesla";
            electricCar.Millage = 1000;
            electricCar.Drive();
            electricCar.ShowInfo();
            electricCar.UseElectric();
        }
    }
}