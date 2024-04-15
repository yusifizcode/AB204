namespace Core.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private static int _id { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }
    }
}
