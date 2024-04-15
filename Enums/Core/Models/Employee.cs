using Core.AppEnums;

namespace Core.Models
{
    public class Employee
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Position: {Position}; Salary: {Salary}";
        }
    }
}
