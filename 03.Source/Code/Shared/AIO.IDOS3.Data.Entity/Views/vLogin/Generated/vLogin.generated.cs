using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vLogin : BaseEntityType, IvLogin
    {
        #region Implements IvLogin

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void CopyFrom(IvLogin obj)
        {
            ID = obj.ID;
            Username = obj.Username;
            Password = obj.Password;

        }

        #endregion
    }
}
