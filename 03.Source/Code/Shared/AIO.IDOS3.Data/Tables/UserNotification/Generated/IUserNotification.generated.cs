﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:09
// Description   : IUserNotification partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IUserNotification.cs'
//       up to one level of this file location inside 'UserNotification' folder.
// ===================================================================================

namespace AIO.IDOS3.Data
{

    public partial interface IUserNotification
    {                
        
        #region Properties
        
        System.Guid ID { get; set; }
        System.DateTime RaisedDate { get; set; }
        int UserID { get; set; }
        int CategoryID { get; set; }
        string HtmlMessage { get; set; }
        bool IsRead { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IUserNotification obj);
        
        #endregion

    }

}
