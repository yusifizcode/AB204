namespace StaticAndExtension
{
    internal class User
    {
        private static int _id;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }



        public User(string username, string password)
        {
            Console.WriteLine("Non-Static constructor run!");
            _id++;
            Id = _id;
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Username} - {Password}; Id: {Id}";
        }

        static User()
        {
            _id = 40;
        }
    }
}
