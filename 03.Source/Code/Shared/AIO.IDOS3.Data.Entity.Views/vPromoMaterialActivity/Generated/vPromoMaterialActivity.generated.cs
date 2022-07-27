﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:16
// Description   : vPromoMaterialActivity partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vPromoMaterialActivity.cs'
//       up to one level of this file location inside 'vPromoMaterialActivity' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vPromoMaterialActivity : BaseEntityType, IvPromoMaterialActivity
    {                
        
        #region Implements IvPromoMaterialActivity

        public System.Guid ID { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public System.Guid SalesmanCallID { get; set; }
        public System.Guid SalesmanID { get; set; }
        public System.DateTime CallDate { get; set; }
        public System.Guid CustomerID { get; set; }
        public string AttachmentFile { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvPromoMaterialActivity obj)
        {
            ID = obj.ID;
            ActivityDate = obj.ActivityDate;
            SalesmanCallID = obj.SalesmanCallID;
            SalesmanID = obj.SalesmanID;
            CallDate = obj.CallDate;
            CustomerID = obj.CustomerID;
            AttachmentFile = obj.AttachmentFile;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
        }
        
        #endregion

    }

}
