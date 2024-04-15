using Core.AppEnums;
using Core.Exceptions;

namespace Core.Models
{
    public class Department
    {
        private static int _id;
        public int Id { get; set; }
        public int EmployeeLimit { get; set; }
        Employee[] _employees;

        public Department()
        {
            _employees = new Employee[] { };
        }

        public void AddEmployee(Employee employee)
        {
            if (_employees.Length < EmployeeLimit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
            else
            {
                throw new OutOfLimitEmployeeException("limit ashildi!!");
            }
        }

        public Employee[] GetAllEmployees()
        {
            return _employees;
        }

        public void RemoveEmployee(int id)
        {
            Employee[] filteredEmployees = { };

            if (_employees.Length > 0)
            {
                foreach (Employee employee in _employees)
                {
                    if (employee.Id != id)
                    {
                        Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
                        filteredEmployees[filteredEmployees.Length - 1] = employee;
                    }
                }
            }

            _employees = filteredEmployees;
        }

        public Employee[] GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            Employee[] filteredEmployees = { };

            if (_employees.Length > 0)
            {
                foreach (Employee employee in _employees)
                {
                    if (employee.Salary >= minSalary && employee.Salary <= maxSalary)
                    {
                        Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
                        filteredEmployees[filteredEmployees.Length - 1] = employee;
                    }
                }
            }

            return filteredEmployees;
        }

        //public Employee[] GetAllEmployeesByPosition(string position)
        //{
        //    Employee[] filteredEmployees = { };

        //    if (_employees.Length > 0)
        //    {
        //        foreach (Employee employee in _employees)
        //        {
        //            if (employee.Position.ToLower() == position.ToLower())
        //            {
        //                Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
        //                filteredEmployees[filteredEmployees.Length - 1] = employee;
        //            }
        //        }
        //    }

        //    return filteredEmployees;
        //}

        public Employee[] GetAllEmployeesByPosition(Position position)
        {
            Employee[] filteredEmployees = { };

            if (_employees.Length > 0)
            {
                foreach (Employee employee in _employees)
                {
                    if (employee.Position == position)
                    {
                        Array.Resize(ref filteredEmployees, filteredEmployees.Length + 1);
                        filteredEmployees[filteredEmployees.Length - 1] = employee;
                    }
                }
            }

            return filteredEmployees;
        }
    }
}
