namespace FactorialTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFactorial(5));
        }

        static int GetFactorial(int x)
        {
            int product = 1;
            for (int i = 1; i <= x; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}