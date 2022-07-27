﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:45
// Description   : IvStockTransfer partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvStockTransfer.cs'
//       up to one level of this file location inside 'vStockTransfer' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvStockTransfer
    {                
        
        #region Properties
        
        System.Guid DocumentID { get; set; }
        string DocumentCode { get; set; }
        System.DateTime TransactionDate { get; set; }
        System.Guid SourceWarehouseID { get; set; }
        string SourceWarehouseCode { get; set; }
        string SourceWarehouseName { get; set; }
        string SourceWarehouse { get; set; }
        System.Guid? SourceSiteID { get; set; }
        string SourceSiteCode { get; set; }
        string SourceSiteName { get; set; }
        string SourceSite { get; set; }
        int SourceAreaID { get; set; }
        string SourceAreaCode { get; set; }
        string SourceAreaName { get; set; }
        string SourceArea { get; set; }
        int? SourceRegionID { get; set; }
        string SourceRegionCode { get; set; }
        string SourceRegionName { get; set; }
        string SourceRegion { get; set; }
        int? SourceTerritoryID { get; set; }
        string SourceTerritoryCode { get; set; }
        string SourceTerritoryName { get; set; }
        string SourceTerritory { get; set; }
        int SourceCompanyID { get; set; }
        string SourceCompanyCode { get; set; }
        string SourceCompanyName { get; set; }
        string SourceCompany { get; set; }
        int SourceSiteDistributionTypeID { get; set; }
        string SourceSiteDistributionTypeName { get; set; }
        bool IsSourceSiteProductLotCodeEntryRequired { get; set; }
        int SourceWarehouseTypeID { get; set; }
        string SourceWarehouseTypeName { get; set; }
        string SourcePIC { get; set; }
        System.Guid DestinationWarehouseID { get; set; }
        string DestinationWarehouseCode { get; set; }
        string DestinationWarehouseName { get; set; }
        string DestinationWarehouse { get; set; }
        System.Guid? DestinationSiteID { get; set; }
        string DestinationSiteCode { get; set; }
        string DestinationSiteName { get; set; }
        string DestinationSite { get; set; }
        int DestinationAreaID { get; set; }
        string DestinationAreaCode { get; set; }
        string DestinationAreaName { get; set; }
        string DestinationArea { get; set; }
        int? DestinationRegionID { get; set; }
        string DestinationRegionCode { get; set; }
        string DestinationRegionName { get; set; }
        string DestinationRegion { get; set; }
        int? DestinationTerritoryID { get; set; }
        string DestinationTerritoryCode { get; set; }
        string DestinationTerritoryName { get; set; }
        string DestinationTerritory { get; set; }
        int DestinationCompanyID { get; set; }
        string DestinationCompanyCode { get; set; }
        string DestinationCompanyName { get; set; }
        string DestinationCompany { get; set; }
        int DestinationSiteDistributionTypeID { get; set; }
        string DestinationSiteDistributionTypeName { get; set; }
        bool IsDestinationSiteProductLotCodeEntryRequired { get; set; }
        int DestinationWarehouseTypeID { get; set; }
        string DestinationWarehouseTypeName { get; set; }
        string DestinationPIC { get; set; }
        string ReferenceNumber { get; set; }
        string AttachmentFile { get; set; }
        System.Guid DODocumentID { get; set; }
        string DODocumentCode { get; set; }
        System.DateTime DOTransactionDate { get; set; }
        System.DateTime? DOShipmentDate { get; set; }
        System.DateTime? DODeliveredDate { get; set; }
        int DOPrintCount { get; set; }
        System.DateTime? DOLastPrintedDate { get; set; }
        int PrintCount { get; set; }
        System.DateTime? LastPrintedDate { get; set; }
        int DocumentStatusID { get; set; }
        string DocumentStatusName { get; set; }
        string MobileDocumentCode { get; set; }
        System.DateTime? PostedDate { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        string CreatedByUserName { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        string ModifiedByUserName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvStockTransfer obj);
        
        #endregion
        
    }

}
