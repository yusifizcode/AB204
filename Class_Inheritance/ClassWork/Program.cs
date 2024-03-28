namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Classroom classroom = new Classroom();

            do
            {
                Console.WriteLine("Telebe elave etmek isteyirsiniz mi? (y|n)");
                answer = Console.ReadLine();

                if (answer == "y")
                {
                    Console.Write("Telebenin adini daxil et: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("");
                    Console.Write("Telebenin soyadini daxil et: ");
                    string surname = Console.ReadLine();

                    Console.WriteLine("");
                    string ageStr = "";
                    byte age;
                    do
                    {
                        Console.Write("Telebenin yashini daxil et: ");
                        ageStr = Console.ReadLine();
                    } while (!byte.TryParse(ageStr, out age));


                    Console.WriteLine("");
                    string pointStr = "";
                    byte point;
                    do
                    {
                        Console.Write("Telebenin balini daxil et: ");
                        pointStr = Console.ReadLine();
                    } while (!byte.TryParse(pointStr, out point));


                    Student student = new Student(name, surname, age, point);


                    classroom.AddStudent(student);
                }
                else if (answer == "n")
                {
                    classroom.ShowAllStudents();
                }
            } while (answer != "n");

        }
    }
}