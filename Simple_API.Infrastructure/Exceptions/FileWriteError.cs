using System;

namespace Simple_API.Infrastructure.Exceptions
{
    public class FileWriteError : FileExceptions
    {
        public FileWriteError(string message, int code) : base(message,code)
        {
        }
    }
}