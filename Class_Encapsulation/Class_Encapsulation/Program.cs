namespace Class_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Brand = "BMW";
            car.Model = "F30";
            car.CurrentFuel = 20;
            Console.WriteLine(car.CurrentFuel);
            //car.CurrentFuelSetter(20);
            //Console.WriteLine(car.CurrentFuelGetter());
            //car.CurrentFuelSetter(20);
            //Console.WriteLine(car.CurrentFuelGetter());

            //car.Drive(10);
            //car.ShowInfo();
        }
    }
}