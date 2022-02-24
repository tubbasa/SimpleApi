using System.Collections.Generic;

namespace Simple_API.Api.Exceptions
{
    public class ApiErrorDTO
    {
        public string Message { get; set; }
            public Dictionary<string, string> Error { get; set; }
        
    }
}