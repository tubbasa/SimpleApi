namespace Simple_API.Infrastructure.Services.Internal
{
    public class AuthorizeService
    {
        public bool CheckToken(string token) =>  token == "testToken";
      
    }
}