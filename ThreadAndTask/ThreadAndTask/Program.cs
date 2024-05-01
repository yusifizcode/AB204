namespace ThreadAndTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Incerement);
            Thread thread2 = new Thread(Decrement);


            thread1.Start();
            thread2.Start();


            Console.WriteLine(Counter);
        }
        public static int Counter { get; set; }
        public static object LockObj1 { get; set; } = new object();
        public static object LockObj2 { get; set; } = new object();
        static void Incerement()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (LockObj1)
                {
                    lock (LockObj2)
                    {
                        Counter++;
                    }
                }
            }
        }

        static void Decrement()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (LockObj2)
                {
                    lock (LockObj1)
                    {
                        Counter--;
                    }
                }
            }
        }
    }
}