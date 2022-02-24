using System;

namespace Simple_API.Infrastructure.Exceptions
{
    public class FileExceptions : Exception
    {
        public virtual string Code { get; }

        public FileExceptions(string message) : base(message)
        {
        }
    }
}