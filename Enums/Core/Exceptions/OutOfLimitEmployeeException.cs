namespace Core.Exceptions
{
    public class OutOfLimitEmployeeException : Exception
    {
        public OutOfLimitEmployeeException(string? message) : base(message)
        {
        }
    }
}
