using System.Linq;
using System.Security.Principal;

namespace MetaWpf.Infrastructures.Model
{
    public class MetaPrincipal :IPrincipal
    {
        private MetaIdentity _identity;

        // Istanzio un oggetto aaPrincipal specifcando ruoli e identita'
        public MetaPrincipal(MetaIdentity identity)
        {
            this._identity = identity;
        }

        public MetaIdentity Identity
        {
            get { return this._identity ?? new AnonymousIdentity(); }
            set { this._identity = value; }
        }

        #region IPrincipal Members
        IIdentity IPrincipal.Identity
        {
            get { return this.Identity; }
        }

        public bool IsInRole(string role)
        {
            return _identity.Roles.Contains(role);
        }
        #endregion
    }
}
