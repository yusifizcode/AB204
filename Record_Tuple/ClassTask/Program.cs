namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee fulltime = new FullTimeEmployee("Anar", "Balaca", "Instructor", 10);
            Employee partTime = new PartTimeEmployee("Anar", "Balaca", "Instructor", 10);
            Employee contractor = new ContracterEmployee("Anar", "Balaca", "Instructor", 10, 50);

            fulltime.ShowInfo();
            fulltime.CalcSalary();

            partTime.ShowInfo();
            partTime.CalcSalary();

            contractor.ShowInfo();
            contractor.CalcSalary();



        }
    }
}