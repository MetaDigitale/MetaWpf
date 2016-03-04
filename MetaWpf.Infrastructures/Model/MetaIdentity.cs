using System.Security.Principal;

namespace MetaWpf.Infrastructures.Model
{
    public class MetaIdentity : IIdentity
    {
        #region Private Properties
        private bool _isAuthenticated = false;
        #endregion

        #region Public Properties
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string[] Roles { get; private set; }
        public bool IsAdministrator { get; private set; }

        #region IIdentity Members
        public string AuthenticationType => "Meta Authentication";
        public bool IsAuthenticated => this._isAuthenticated;

        #endregion
        #endregion

        public MetaIdentity(string name, bool isAdministrator)
        {
            this.Name = name;
            this.IsAdministrator = isAdministrator;
        }
    }
}
