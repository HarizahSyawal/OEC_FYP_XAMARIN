using System;
namespace AIO.IDOS3.Data
{
    public partial interface ILogin
    {
        #region Properties

        int ID { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        #endregion

        #region Methods

        void CopyFrom(ILogin obj);

        #endregion
    }
}
