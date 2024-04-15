namespace Abstractions
{
    internal abstract class Shape
    {
        public abstract void CalculateArea(int n1, int n2);

        public virtual void CalcArea(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

    }
}
