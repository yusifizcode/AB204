namespace Core.Models
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color: {Color}; Brand: {Brand}; Millage: {Millage}");
        }

        public abstract void Drive();
    }
}
