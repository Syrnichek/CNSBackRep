namespace CNSBack.Exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string message)
            : base(message) { }
    }
    
    public class NewsAlreadyExistsException : Exception
    {
        public NewsAlreadyExistsException(string message)
            : base(message) { }
    }
}