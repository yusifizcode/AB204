namespace Abstractions
{
    internal class Rectangle : Shape
    {
        public override void CalculateArea(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }
}
