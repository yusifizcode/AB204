namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                var c = 10 / num;
                //var a = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("string gondermek olmaz!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0a bolmek olmaz!");
            }
            catch (Exception)
            {
                Console.WriteLine("bilinmedik xeta!");
            }
        }
    }
}