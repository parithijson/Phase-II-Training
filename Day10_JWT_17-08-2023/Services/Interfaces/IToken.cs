namespace UserJWT.Services.Interfaces
{
    public interface IToken
    {
        public string GeneraterToken(string username, string isAdmin);
    }
}
