namespace ClassTask.Models.EmployeeModel
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        private double _salary;
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }
    }
}
