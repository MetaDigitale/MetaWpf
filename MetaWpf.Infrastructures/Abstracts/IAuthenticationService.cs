using MetaWpf.Infrastructures.Model;

namespace MetaWpf.Infrastructures.Abstracts
{
    public interface IAuthenticationService
    {
        User AuthenticateUser(string username, string password);
    }
}
