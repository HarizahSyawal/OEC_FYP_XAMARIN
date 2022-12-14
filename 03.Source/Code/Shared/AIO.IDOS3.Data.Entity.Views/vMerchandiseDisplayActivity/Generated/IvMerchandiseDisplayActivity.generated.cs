// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:08
// Description   : IvMerchandiseDisplayActivity partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvMerchandiseDisplayActivity.cs'
//       up to one level of this file location inside 'vMerchandiseDisplayActivity' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvMerchandiseDisplayActivity
    {                
        
        #region Properties
        
        System.Guid ID { get; set; }
        System.DateTime ActivityDate { get; set; }
        System.Guid SalesmanCallID { get; set; }
        System.Guid SalesmanID { get; set; }
        System.DateTime CallDate { get; set; }
        System.Guid CustomerID { get; set; }
        string AttachmentFile { get; set; }
        System.DateTime? CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvMerchandiseDisplayActivity obj);
        
        #endregion
        
    }

}
