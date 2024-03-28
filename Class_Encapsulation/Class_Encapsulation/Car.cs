namespace Class_Encapsulation
{
    internal class Car
    {
        public string Brand;
        public string Model; // field
        private double _currentFuel; // field
        public double FuelFor1Km; //10
        public double Millage; // 2000

        public double CurrentFuel
        {
            get //CurrentFuelGetter()
            {
                return _currentFuel;
            }
            set //CurrentFuelSetter()
            {
                if (value > 0)
                {
                    _currentFuel = value;
                }
            }
        } //property

        //public double CurrentFuelGetter()
        //{
        //    return _currentFuel;
        //}

        //public void CurrentFuelSetter(double value)
        //{
        //    if (value > 0)
        //    {
        //        _currentFuel = value;
        //    }
        //}

        //public void Drive(int km) // 10
        //{
        //    if (km * FuelFor1Km <= CurrentFuel)
        //    {
        //        CurrentFuel -= km * FuelFor1Km;
        //        Millage += km;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yeterli benzin yoxdur!");
        //    }
        //}

        //public void ShowInfo()
        //{
        //    Console.WriteLine($"{Brand}, {Model},CurrentFuel: {CurrentFuel},FuelFor1Km: {FuelFor1Km}, Millage: {Millage}");
        //}
    }
}
