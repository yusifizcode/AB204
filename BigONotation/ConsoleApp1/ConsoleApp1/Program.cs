namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 12;

            //if (age > 18)
            //{
            //    Console.WriteLine("Adult");
            //}
            //else
            //{
            //    Console.WriteLine("Child");
            //}


            //string[] arr = { "Nicat", "Sirac", "Samir", "Mehemmed", "Fuad", "Zaman", "Efsane", "Riad" };

            //int step = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    step++;
            //    if (arr[i] == "Riad")
            //    {
            //        Console.WriteLine(arr[i]);
            //        break;
            //    }
            //}

            //Console.WriteLine(step);


            //int number = 169;
            //int step = 0;

            //for (int i = 2; i * i <= number; i++)
            //{
            //    step++;
            //    if (number % i == 0)
            //    {
            //        Console.WriteLine("Murekkebdir");
            //        break;
            //    }
            //}

            //Console.WriteLine(step);


            //string[] arr = { "Nicat", "Sirac", "Samir", "Mehemmed", "Fuad", "Zaman", "Efsane", "Riad" };

            //int step = 0;
            //bool check = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        step++;
            //        if (arr[i][j] == 'd')
            //        {
            //            Console.WriteLine(arr[i]);
            //            check = true;
            //        }
            //    }
            //    if (check == true)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(step);



            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int step = 0;
            int wantedNumber = 12;

            for (int i = 0; i < arr.Length; i++)
            {
                step++;
                if (arr[i] == wantedNumber)
                {
                    Console.WriteLine(wantedNumber);
                    break;
                }

            }

            Console.WriteLine("step= " + step);

            //int startIndex = 0;
            //int endIndex = arr.Length - 1;
            //int wantedNumber = 12;
            //int step = 0;
            //while (startIndex <= endIndex)
            //{
            //    int mid = startIndex + (endIndex - startIndex) / 2;

            //    if (arr[mid] == wantedNumber)
            //    {
            //        Console.WriteLine(wantedNumber);
            //        break;
            //    }
            //    else if (arr[mid] < wantedNumber)
            //    {
            //        startIndex = mid + 1;
            //    }
            //    else
            //    {
            //        endIndex = mid - 1;
            //    }
            //    step++;
            //}

            //Console.WriteLine(step);
        }
    }
}