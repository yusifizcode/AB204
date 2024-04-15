namespace CSharpIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] arr = { "salam", "sagol", "lorem" };
            //int[] arr2 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr2[2]);

            int[] arr = { 1, 23, 4, 5, 6 };
            int[] arr2 = { 2, 3, 5, 6, 6 };
            int[] arr3 = { 5, 6, 7, 8, 8 };

            CustomIntArray customIntArray = new CustomIntArray();

            customIntArray.Add(1);
            customIntArray.Add(2);
            customIntArray.Add(3);
            customIntArray.Add(4);
            customIntArray.Add(5);

            Console.WriteLine(Sum(2)); ;
            var a = customIntArray[2];
            var b = customIntArray.Arr[2];
            //Console.WriteLine(a);
            //Console.WriteLine(b);










            //customIntArray[2] = 4;


            //for (int i = 0; i < customIntArray.Arr.Length; i++)
            //{
            //    Console.WriteLine(customIntArray.Arr[i]);
            //}
            //Console.WriteLine("------------------------");

            //customIntArray.Remove(2);

            //for (int i = 0; i < customIntArray.Arr.Length; i++)
            //{
            //    Console.WriteLine(customIntArray.Arr[i]);
            //}

        }


        static int Sum(int index)
        {
            return index;
        }
    }
}