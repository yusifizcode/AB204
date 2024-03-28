namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;

            //Console.WriteLine("Initial value: " + number);

            //ChangeIntValue(number);

            //Console.WriteLine("After Method: " + number);

            //int a = 5;
            //int b = 6;

            //a = b; // a = 6
            //b = 8; // b = 8

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] arr = { 1, 2, 3, 4, 5 }; // 0x123

            //int[] arr2 = { 6, 7, 8, 9, 10 }; // 0x456

            //arr = arr2; // 0x456
            //arr2 = new int[] { 45, 566, 67, 98 }; // 0x567

            //arr = arr2; // 0x567

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("--------------------");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}


            // ref, out -> deyeri yox, referansini oturur
            //int number = 34;

            //Console.WriteLine(number);
            //ChangeIntValue(out number);
            //Console.WriteLine(number);

            //do
            //{
            //Console.WriteLine("Nese daxil edin: ");
            //string inputStr = Console.ReadLine();
            //bool check = false;
            //for (int i = 0; i < inputStr.Length; i++)
            //{
            //    if (char.IsLetter(inputStr[i]))
            //    {
            //        check = true;
            //        break;
            //    }
            //}

            //if (check == false)
            //{
            //    int inputInt = Convert.ToInt32(inputStr);

            //    Console.WriteLine("int: " + inputInt);
            //    break;
            //}


            //} while (true);

            //Console.WriteLine("Nese daxil et: ");
            //string inputStr = Console.ReadLine();
            //bool isInt = int.TryParse(inputStr, out int result);
            //Console.WriteLine(isInt);
            //Console.WriteLine(result);
            //string inputStr;
            //int result;
            //do
            //{
            //    Console.WriteLine("Nese daxil et: ");
            //    //inputStr = Console.ReadLine();
            //} while (!int.TryParse(Console.ReadLine(), out result));

            //Console.WriteLine(result);
        }

        //static void ChangeIntValue(out int a)
        //{
        //    a = 50;
        //    Console.WriteLine("Inside Method: " + a);
        //}
    }
}