namespace ConditionsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If, Else If, Else
            //int n = 47;

            //if (n % 3 == 0)
            //{
            //    if (n % 5 == 0)
            //    {
            //        Console.WriteLine("her ikisine bolunur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3e bolunur");
            //    }
            //}
            //else
            //{
            //    if (n % 5 == 0)
            //    {
            //        Console.WriteLine("5e bolunur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("hec birine bolunmur");
            //    }
            //}


            //int point = 5;

            //if (point >= 0 && point <= 100)
            //{
            //    if (point >= 91)
            //    {
            //        Console.WriteLine("A");
            //    }
            //    else if (point >= 81)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else if (point >= 71)
            //    {
            //        Console.WriteLine("C");
            //    }
            //    else if (point >= 61)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else if (point >= 51)
            //    {
            //        Console.WriteLine("E");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kesr");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun deyer daxil edin!");
            //}



            //int weekOfDay = 1;

            //if (weekOfDay >= 1 && weekOfDay <= 7)
            //{

            //    if (weekOfDay == 1)
            //    {
            //        Console.WriteLine("Bazar ertesi");
            //    }
            //    else if (weekOfDay == 2)
            //    {
            //        Console.WriteLine("C.A");
            //    }
            //    else if (weekOfDay == 3)
            //    {
            //        Console.WriteLine("C");
            //    }
            //    else if (weekOfDay == 4)
            //    {
            //        Console.WriteLine("Cume.A");
            //    }
            //    else if (weekOfDay == 5)
            //    {
            //        Console.WriteLine("Cume");
            //    }
            //    else if (weekOfDay == 6)
            //    {
            //        Console.WriteLine("Shenbe");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bazar");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Heftenin gununu duzgun daxil edin!");
            //}

            #endregion

            #region Switch Case
            //int weekOfDay = 1;
            //string result = "Duzgun deyer daxil edin!";


            //if (weekOfDay >= 1 && weekOfDay <= 7)
            //{
            //    result = weekOfDay switch
            //    {
            //        1 => "Bazar ertesi",
            //        2 => "C.A",
            //        3 => "C",
            //        4 => "Cume A.",
            //        5 => "Cume",
            //        6 => "Shenbe",
            //        7 => "Bazar"
            //    };
            //}

            //Console.WriteLine(result);

            //switch (weekOfDay)
            //{
            //    case 1:
            //        Console.WriteLine("Bazar ertesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("C.A");
            //        break;
            //    case 3:
            //        Console.WriteLine("C");
            //        break;
            //    case 4:
            //        Console.WriteLine("Cume A.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cume");
            //        break;
            //    case 6:
            //        Console.WriteLine("Shenbe");
            //        break;
            //    case 7:
            //        Console.WriteLine("Bazar");
            //        break;
            //    default:
            //        Console.WriteLine("Duzgun deyer daxil et!!");
            //        break;
            //}
            #endregion

            #region While
            //int a = 1;
            //int sum = 0;

            //if (a % 2 == 0)
            //{
            //    sum += a;
            //}
            //a++;
            //if (a % 2 == 0)
            //{
            //    sum += a;
            //}
            //a++;
            //if (a % 2 == 0)
            //{
            //    sum += a;
            //}
            //a++;
            //if (a % 2 == 0)
            //{
            //    sum += a;
            //}
            //a++;
            //if (a % 2 == 0)
            //{
            //    sum += a;
            //}

            //Console.WriteLine(sum);


            // While, Do While, For

            //int i = 1;
            //int sum = 0;

            //while (i < 6)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}

            //Console.WriteLine(sum);
            #endregion

            #region For
            //int sum = 0;

            //for (int i = 1; i < 6; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine(sum);
            #endregion

            #region String Interpolation
            //Console.WriteLine("Istifadeci adini yazin: ");
            //string username = Console.ReadLine();

            //Console.WriteLine($"Istifadeci adiniz: {username}"); // stirng interpolation
            #endregion

            #region Do While
            //Console.WriteLine("Istifadeci adini yazin: ");
            //string username = Console.ReadLine();

            //while (username != "yusif")
            //{
            //    Console.WriteLine("Istifadeci duzgun yazin: ");
            //    username = Console.ReadLine();
            //}

            //string username = "";
            //string password = "";
            //do
            //{
            //    Console.WriteLine("Istifadeci adini daxil edin: ");
            //    username = Console.ReadLine();
            //} while (username != "yusif");

            //do
            //{
            //    Console.WriteLine("Shifrenizi daxil edin: ");
            //    password = Console.ReadLine();
            //} while (password != "salam123");
            #endregion

            #region Continue
            //for (int i = 0; i < 10; i += 2)
            //{
            //    //if (i == 0)
            //    //    continue;  if-in ici eger 1 setirdirse, scope'a ehtiyac yoxdur

            //    if (i == 0)
            //    {
            //        continue; // eger kod bu setri oxuyursa, novbeti setirleri icra etmeden donguye qayidir.
            //    }


            //    Console.WriteLine(i);
            //}
            #endregion

            #region Break
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        break; // bu keyword oxunandan sonra dongu dayanir

            //    Console.WriteLine(i);
            //}
            #endregion

        }
    }
}