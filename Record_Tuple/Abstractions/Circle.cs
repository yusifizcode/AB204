namespace Abstractions
{
    internal class Circle : Shape
    {
        public override void CalculateArea(int n1, int n2)
        {
            Console.WriteLine(n1 * n2 * n2);
        }

        public override void CalcArea(int n1, int n2)
        {
            Console.WriteLine(n1 * n2 * n2);
        }
    }
}
