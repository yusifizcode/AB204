namespace ClassWork
{
    internal class Classroom
    {
        public Student[] Students = new Student[] { };

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public Student[] GetAllStudent()
        {
            return Students;
        }

        public void ShowAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"{Students[i].GetFullData()}, Point: {Students[i].Point}");
            }
        }
    }
}
