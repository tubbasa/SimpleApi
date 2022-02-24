using System;

namespace Simple_API.Infrastructure.Exceptions
{
    public class FileExceptions : Exception
    {
        public int Code { get; }

        public FileExceptions(string message, int code) : base(message)
        {
            Code = code;
        }
    }
}