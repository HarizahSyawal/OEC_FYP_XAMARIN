using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.IDOS3.Data
{ 
    public partial interface IRegister
    {
        #region Properties

        int ID { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        string Password { get; set; }

        #endregion

        #region Methods

        void CopyFrom(IRegister obj);

        #endregion

    }
}
