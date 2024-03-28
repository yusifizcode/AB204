namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { 8, 9, 10, 11, 12, 13, 14 };

            //GetProductNumbers(1, 2, 4, 5, 5, 665, 7, 3, 423, 412, 423);

            //PrintProductNumbers(arr);

            //PrintProductNumbers(arr2);

            //string a = GetFullName("Enver", "Zohrabov");
            //a += " salam";

            //Console.WriteLine(a);
            //Console.WriteLine(GetFullName("Enver", "Zohrabov"));

            //int b = 5;
            //Console.WriteLine(5);


            //ShowFullName("Enver", "Zohrabov");
            //ShowFullName("Anar", "Balacayev");

            Console.WriteLine(SumNumbers(1, 2));

            SumNumbers(123, "asd");
        }

        static int SumNumber(string fuad, int riad)
        {
            return 0;
        }

        static int SumNumbers(int a, string b)
        {
            return 0;
        }

        static int SumNumbers(int a, int b)
        {
            return a + b;
        }

        static string SumNumbers(int a, int b, int c)
        {
            //int c = a + b;
            return a + b + "=" + a + "+" + b;
        }


        static int GetProductNumbers(int a, params int[] yusif)
        {
            //Console.WriteLine(a);
            int product1 = 1;
            for (int i = 0; i < yusif.Length; i++)
            {
                product1 *= yusif[i];
            }

            return product1;
        }

        static string GetFullName(string name, string surname, string fatherName)
        {
            string fullname = name + " " + surname;
            return fullname;
        }

        static void ShowFullName(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }



    }
}