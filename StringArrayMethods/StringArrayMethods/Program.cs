namespace StringArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("salam");
            //Console.WriteLine($"Initial value: {stringBuilder}; Initial Hash code: {stringBuilder.GetHashCode()}");
            //stringBuilder.Append(" sagol");
            //Console.WriteLine($"Initial value: {stringBuilder}; Initial Hash code: {stringBuilder.GetHashCode()}");

            //Console.WriteLine("--------------------------");

            //string a = "salam";
            //Console.WriteLine($"Initial value: {a}; Initial Hash code: {a.GetHashCode()}");
            //a += " sagol";
            //Console.WriteLine($"Initial value: {a}; Initial Hash code: {a.GetHashCode()}");

            // all value types and string - immutuble
            // other reference types - mutuble, StringBuffer


            string a = "salam";
            string[] arr = { "salam", "sagol", "necesen" };
            //int[] arr1 = { 1, 23, 4, 5, 656, 56 };

            //Console.WriteLine(String.Join(" ", arr1));
            //Console.WriteLine(a.Replace('a', 'b'));
            //Console.WriteLine(a.ToUpper());
            //Console.WriteLine(a.ToLower());
            //Console.WriteLine(String.Concat(a, " sagol"));
            //Console.WriteLine(String.Join(" ", arr));
            //string str1 = "abc";
            //string str2 = "ABC";

            //Console.WriteLine(String.Compare(str1, str2, true));
            //string b = "     ";

            //Console.WriteLine(String.IsNullOrWhiteSpace(b)); //true
            //string b1 = "    ";

            //Console.WriteLine(String.IsNullOrEmpty(b)); //false

            string s = "salam salam salam salam salam salam salam salam salam salam salam";
            //Console.WriteLine(s.StartsWith("f"));
            //Console.WriteLine(s.EndsWith("z"));
            //Console.WriteLine(s.IndexOf('a'));
            //Console.WriteLine(s.LastIndexOf('a'));
            //char[] chrs = s.ToCharArray();

            //for (int i = 0; i < chrs.Length; i++)
            //{
            //    Console.WriteLine(chrs[i]);
            //}

            //Console.WriteLine(String.Join(",", s.Split(' ')));

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i]);
            //}

            //Console.WriteLine(s.Contains(" "));
            string s1 = "     Hello, AB204     ";
            //Console.WriteLine(s1.Substring(0));
            s1 = s1.Trim();
            //Console.WriteLine(s1);
            Console.WriteLine(s1.Remove(s1.IndexOf(','), 2));
        }
    }
}