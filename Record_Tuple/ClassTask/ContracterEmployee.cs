namespace ClassTask
{
    public class ContracterEmployee : Employee
    {
        public int WorkingHoursForMonth { get; set; }
        public ContracterEmployee(string name, string surName, string position, int salaryForHour, int workingHoursForMonth) : base(name, surName, position, salaryForHour)
        {
            WorkingHoursForMonth = workingHoursForMonth;
        }

        public override void CalcSalary()
        {
            Console.WriteLine(WorkingHoursForMonth * SalaryForHour);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} SurName{SurName} Position{Position} SalaryForHour{SalaryForHour} WorkingHoursForMonth {WorkingHoursForMonth}");

        }
    }
}
