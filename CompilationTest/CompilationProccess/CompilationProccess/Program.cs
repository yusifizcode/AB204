namespace CompilationProccess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 3, 4, 5, 6, 7 };
            //Console.WriteLine(Sum(3, 5));

            Sum(1, 3);
        }


        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}