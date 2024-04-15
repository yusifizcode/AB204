namespace ClassTask
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, string surName, string position, int salaryForHour) : base(name, surName, position, salaryForHour)
        {
        }

        public override void CalcSalary()
        {
            Console.WriteLine(SalaryForHour * 240);
        }


    }
}
