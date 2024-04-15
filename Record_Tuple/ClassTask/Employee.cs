namespace ClassTask
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public int SalaryForHour { get; set; }

        public Employee(string name, string surName, string position, int salaryForHour)
        {
            Name = name;
            SurName = surName;
            Position = position;
            SalaryForHour = salaryForHour;
        }

        public abstract void CalcSalary();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} SurName{SurName} Position{Position} SalaryForHour{SalaryForHour}");
        }

    }
}
