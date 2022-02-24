using System;
using System.Globalization;

namespace Simple_API.Api.Exceptions
{
    public class TokenCouldNotValidated : TokenException
    {
        public TokenCouldNotValidated(string message, int code) : base(message, code)
        {
        }
    }
}