
namespace MetaWpf.Infrastructures.Model
{
    public class User
    {
        public User(string username, string email, string[] roles)
        {
            this.Username = username;
            this.Email = email;
            this.Roles = roles;
        }

        public string Username
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string[] Roles
        {
            get;
            set;
        }
    }
}
