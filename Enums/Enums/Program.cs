using Core.AppEnums;
using Core.Exceptions;
using Core.Models;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.EmployeeLimit = 1;
            bool check = true;
            do
            {
                Console.WriteLine("Choose one: ");
                Console.WriteLine("1. AddEmployee\n" +
                                  "2. GetAllEmployees\n" +
                                  "3. RemoveEmployee\n" +
                                  "4. FilterEmployeeBySalary\n" +
                                  "5. FilterEmployeeByPosition\n" +
                                  "0. Exit");
                string answer = Console.ReadLine();
                byte answerByte = byte.Parse(answer);
                switch (answerByte)
                {
                    case (byte)Menu.AddEmployee:

                        Console.WriteLine("Enter employee name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter employee salary: ");
                        string salaryStr = Console.ReadLine();
                        double salary = double.Parse(salaryStr);

                        Console.WriteLine("Choose one position: ");
                        Console.WriteLine("1. Backend\n" +
                                          "2. FrontEnd\n" +
                                          "3. Ishsiz\n" +
                                          "4. QA\n" +
                                          "5. Designer\n");

                        string choicePosition = Console.ReadLine();
                        byte choicePositionByte = byte.Parse(choicePosition);

                        Employee employee = new Employee()
                        {
                            Name = name,
                            Salary = salary,
                            Position = (Position)choicePositionByte
                        };

                        try
                        {
                            department.AddEmployee(employee);
                        }
                        catch (OutOfLimitEmployeeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case (byte)Menu.GetAllEmployees:

                        foreach (Employee emp in department.GetAllEmployees())
                        {
                            Console.WriteLine(emp);
                        }
                        break;

                    case (byte)Menu.RemoveEmployee:

                        foreach (Employee emp in department.GetAllEmployees())
                        {
                            Console.WriteLine(emp);
                        }

                        Console.WriteLine("Enter Id: ");
                        string idStr = Console.ReadLine();
                        int id = int.Parse(idStr);

                        department.RemoveEmployee(id);
                        break;
                    case (byte)Menu.FilterEmployeeBySalary:

                        Console.WriteLine("Enter min salary: ");
                        string minSalaryStr = Console.ReadLine();
                        int minSalary = int.Parse(minSalaryStr);

                        Console.WriteLine("Enter max salary: ");
                        string maxSalaryStr = Console.ReadLine();
                        int maxSalary = int.Parse(maxSalaryStr);

                        foreach (Employee emp in department.GetAllEmployeesBySalary(minSalary, maxSalary))
                        {
                            Console.WriteLine(emp);
                        }
                        break;
                    case (byte)Menu.FilterEmployeeByPosition:

                        Console.WriteLine("Choose one: ");
                        Console.WriteLine("1. Backend\n" +
                                          "2. FrontEnd\n" +
                                          "3. Ishsiz\n" +
                                          "4. QA\n" +
                                          "5. Designer\n");

                        choicePosition = Console.ReadLine();
                        choicePositionByte = byte.Parse(choicePosition);

                        foreach (Employee emp in department.GetAllEmployeesByPosition((Position)choicePositionByte))
                        {
                            Console.WriteLine(emp);
                        }
                        break;
                    case (byte)Menu.Exit:
                        check = false;
                        break;
                    default:
                        break;
                }
            } while (check);



            //Console.WriteLine("Butun ishciler");
            //foreach (Employee emp in department.GetAllEmployees())
            //{
            //    Console.WriteLine(emp);
            //}

            //department.RemoveEmployee(1);

            //Console.WriteLine("Butun ishciler");
            //foreach (Employee emp in department.GetAllEmployees())
            //{
            //    Console.WriteLine(emp);
            //}

            //Console.WriteLine("Filter salary");
            //foreach (Employee emp in department.GetAllEmployeesBySalary(500, 1500))
            //{
            //    Console.WriteLine(emp);
            //}

            //Console.WriteLine("Filter position");
            //foreach (Employee emp in department.GetAllEmployeesByPosition(Position.Backend))
            //{
            //    Console.WriteLine(emp);
            //}


        }
    }
}