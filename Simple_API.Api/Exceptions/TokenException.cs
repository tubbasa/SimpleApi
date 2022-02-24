using System;

namespace Simple_API.Api.Exceptions
{
    public abstract class TokenException : Exception
    {
        public int Code { get; }

        public TokenException(string message, int code) : base(message)
        {
            Code = code;
        }
    }
}