namespace ClassTask
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, string surName, string position, int salaryForHour) : base(name, surName, position, salaryForHour)
        {
        }

        public override void CalcSalary()
        {
            Console.WriteLine(SalaryForHour * 120);
        }
    }
}
