using System.Security.Principal;

namespace Wismapi.Web.Security
{
    public class BasicGenericIdentity<T> : GenericIdentity
    {

        #region Constructors

        public BasicGenericIdentity(string name, T userData) :
            base(name) 
        {
            UserData = userData;
        }

        #endregion

        #region Properties

        public T UserData { get; }

        #endregion

    }

}
