﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:40
// Description   : IvStockReceival partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvStockReceival.cs'
//       up to one level of this file location inside 'vStockReceival' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvStockReceival
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid WarehouseID { get; set; }
        string WarehouseCode { get; set; }
        string WarehouseName { get; set; }
        string Warehouse { get; set; }
        System.Guid? SiteID { get; set; }
        string SiteCode { get; set; }
        string SiteName { get; set; }
        string Site { get; set; }
        int AreaID { get; set; }
        string AreaCode { get; set; }
        string AreaName { get; set; }
        string Area { get; set; }
        int? RegionID { get; set; }
        string RegionCode { get; set; }
        string RegionName { get; set; }
        string Region { get; set; }
        int? TerritoryID { get; set; }
        string TerritoryCode { get; set; }
        string TerritoryName { get; set; }
        string Territory { get; set; }
        int CompanyID { get; set; }
        string CompanyCode { get; set; }
        string CompanyName { get; set; }
        string Company { get; set; }
        int SiteDistributionTypeID { get; set; }
        string SiteDistributionTypeName { get; set; }
        bool IsSiteProductLotCodeEntryRequired { get; set; }
        int WarehouseTypeID { get; set; }
        string WarehouseTypeName { get; set; }
        string PIC { get; set; }
        string ReferenceNumber { get; set; }
        string AttachmentFile { get; set; }
        int DocumentStatusID { get; set; }
        string DocumentStatusName { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvStockReceival obj);
        
        #endregion
        
    }

}
