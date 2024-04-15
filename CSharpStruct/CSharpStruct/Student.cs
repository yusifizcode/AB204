namespace CSharpStruct
{
    internal struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }

    class Teacher
    {

    }
    interface IReadable
    {
        void Read();
    }

    struct Human
    {

    }
}
