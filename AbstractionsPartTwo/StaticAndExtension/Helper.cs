namespace StaticAndExtension
{
    internal static class Helper
    {
        public static bool CheckPassword(string password)
        {

            bool checkUpper = false;
            bool checkLower = false;
            bool checkDigit = false;
            if (password.Length > 6)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        checkUpper = true;
                    }
                    else if (char.IsLower(password[i]))
                    {
                        checkLower = true;
                    }
                    else if (char.IsDigit(password[i]))
                    {
                        checkDigit = true;
                    }
                }

                if (checkUpper && checkLower && checkDigit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}