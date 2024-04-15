namespace StaticAndExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {


            byte a = 100;
            byte b = 255;
            byte c = (byte)(a + b);
            Console.WriteLine(c);


            string fullName = "Salam";
            Console.WriteLine(fullName.CheckFullName(7));

            //int a = 4;
            //Console.WriteLine(a.IsEven());
            //Console.WriteLine(Extensions.CheckFullName(fullName));
            //User user = new User("test", "test");

            //Console.WriteLine(user);

            //User user1 = new User("test", "test");
            //User user2 = new User("test", "test");
            //User user3 = new User("test", "test");
            //User user4 = new User("test", "test");

            //string pass = "Salam123";
            //if (Helper.CheckPassword(pass))
            //{
            //    User user = new User("test", pass);
            //}

            //string adminPass = "admin123";

            //if (Helper.CheckPassword(adminPass))
            //{
            //    Admin admin = new Admin();
            //}



        }
    }
}