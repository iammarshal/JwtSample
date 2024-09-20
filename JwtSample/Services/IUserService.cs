namespace JwtSample.Services
{
    public interface IUserService
    {
        string Login(string userName, string password);
    }
}
