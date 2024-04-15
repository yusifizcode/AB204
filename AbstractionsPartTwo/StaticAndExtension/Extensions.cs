namespace StaticAndExtension
{
    internal static class Extensions
    {

        //Yusif Osmanov
        public static bool CheckFullName(this string fullName, int a)
        {
            Console.WriteLine(a);
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                fullName = fullName.Trim();
                if (char.IsUpper(fullName[0]))
                {
                    for (int i = 1; i < fullName.Length; i++)
                    {
                        if (fullName[i] == ' ' && char.IsUpper(fullName[i + 1]))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    Console.WriteLine("1ci herf boyuk olmalidir!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("String null ola bilmez!");
                return false;
            }

        }


        public static char FindCenterLetter(this string word)
        {
            return word[word.Length / 2];
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

    }
}
