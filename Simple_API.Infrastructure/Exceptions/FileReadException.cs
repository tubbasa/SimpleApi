namespace Simple_API.Infrastructure.Exceptions
{
    public class FileReadException : FileExceptions
    {
        public FileReadException(string message, int code) : base(message,code)
        {
        }
    }
}