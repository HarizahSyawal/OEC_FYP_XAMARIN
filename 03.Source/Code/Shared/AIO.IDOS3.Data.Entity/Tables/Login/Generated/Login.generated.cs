using System;
namespace AIO.IDOS3.Data.Entity
{
    public partial class Login : ILogin
    {
        #region Implements ILogin

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }



        public void CopyFrom(ILogin obj)
        {
            ID = obj.ID;
            Username = obj.Username;
            Password = obj.Password;
        }

        #endregion
    }
}
