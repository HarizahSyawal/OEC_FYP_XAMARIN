﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:47
// Description   : ICustomerBillGroupHead partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICustomerBillGroupHead.cs'
//       up to one level of this file location inside 'CustomerBillGroupHead' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICustomerBillGroupHead
    {                
        
        #region Properties
        
        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Tag1 { get; set; }
        string Tag2 { get; set; }
        string Tag3 { get; set; }
        string Tag4 { get; set; }
        string Tag5 { get; set; }
        string Tag6 { get; set; }
        string Tag7 { get; set; }
        string Tag8 { get; set; }
        string Tag9 { get; set; }
        string Tag10 { get; set; }
        int? StatusID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICustomerBillGroupHead obj);
        
        #endregion

    }

}
