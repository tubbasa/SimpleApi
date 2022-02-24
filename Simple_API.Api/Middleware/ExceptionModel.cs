using Newtonsoft.Json;

namespace Simple_API.Api.Middleware
{
    public class ApiResponse
    {
        public int StatusCode { get; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; }
   
        public ApiResponse(string message,int statusCode=500)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ApiResponse()
        {
            
        }
    }
}