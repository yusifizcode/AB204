namespace Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal dog = new Dog(true);
            //dog.MakeSound();
            //dog.Eat();

            //Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();

            //circle.CalcArea(2, 3);

            //circle.CalculateArea(2, 3);
            //rectangle.CalculateArea(4, 5);

            //Test(1,2);

            Shape shape = new Circle();
            shape.CalcArea(1, 2);

            Circle circle = new Circle();
            circle.CalcArea(1, 2);
        }

        static void Test(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        static void Test(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
    }

}