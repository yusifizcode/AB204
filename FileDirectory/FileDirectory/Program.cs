namespace FileDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:\\Users\\User\\Desktop";
            //DirectoryInfo directoryInfo = new DirectoryInfo(path);

            //directoryInfo.Create();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Directories: ");
            //Console.ForegroundColor = ConsoleColor.White;
            //foreach (var item in directoryInfo.GetDirectories())
            //{
            //    Console.WriteLine($"{item.Name} - {item.FullName} - {item.Parent.Parent.Parent} - {item.Attributes} - {item.CreationTime} - {item.LastAccessTime}");
            //    Console.WriteLine("============================");
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("SubDirectories: ");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    foreach (var sub in item.GetDirectories())
            //    {
            //        Console.WriteLine($"\t{sub.Name} - {sub.FullName} - {sub.Parent.Parent.Parent} - {sub.Attributes} - {sub.CreationTime} - {sub.LastAccessTime}");
            //        Console.WriteLine("============================");
            //    }
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Files: ");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    foreach (var sub in item.GetFiles())
            //    {
            //        Console.WriteLine($"\t{sub.Name} - {sub.FullName} ");
            //        Console.WriteLine("============================");
            //    }
            //}


            //foreach (var item in directoryInfo.GetFiles())
            //{
            //    Console.WriteLine($"{item.FullName}");
            //}

            //foreach (var item in directoryInfo.GetFiles())
            //{
            //    Console.WriteLine($"{item.Name} - {item.FullName}");
            //}

            string filePath = "C:\\Users\\User\\Desktop\\AB204Test\\Test.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            //File.WriteAllText(filePath, "salam");
            List<string> words = new List<string> { "test", "salam", "sagol" };

            File.WriteAllLines(filePath, words);
            foreach (var item in File.ReadAllLines(filePath))
            {
                Console.WriteLine(item);
            }

        }
    }
}