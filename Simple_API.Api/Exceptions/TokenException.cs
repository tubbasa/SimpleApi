using System;

namespace Simple_API.Api.Exceptions
{
    public abstract class ApiException : Exception
    {
        public virtual string Code { get; }

        public ApiException(string message) : base(message)
        {
        }
    }
}