namespace Simple_API.Api.Exceptions
{
    public class TokenCouldNotValidated : ApiException
    {
        public TokenCouldNotValidated(string code, string error) : base(code, error)
        {
        }
    }
}