using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vRegister : BaseEntityType, IvRegister
    {
        #region Implements IvRegister

        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        public void CopyFrom(IvRegister obj)
        {
            ID = obj.ID;
            Username = obj.Username;
            Email  = obj.Email;
            Password = obj.Password;

        }

        #endregion
    }
}
