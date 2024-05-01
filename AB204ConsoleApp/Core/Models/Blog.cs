namespace AB204ConsoleApp.Models
{
    public class Blog
    {
        static int _id { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Blog()
        {
            _id++;
            Id = _id;
        }
    }
}
