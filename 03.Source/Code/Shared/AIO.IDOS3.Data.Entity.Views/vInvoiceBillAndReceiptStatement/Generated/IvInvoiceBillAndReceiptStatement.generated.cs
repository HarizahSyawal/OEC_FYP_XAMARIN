// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:05
// Description   : IvInvoiceBillAndReceiptStatement partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IvInvoiceBillAndReceiptStatement.cs'
//       up to one level of this file location inside 'vInvoiceBillAndReceiptStatement' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IvInvoiceBillAndReceiptStatement
    {                
        
        #region Properties
        
        System.Guid InvoiceDocumentID { get; set; }
        System.Guid BARSDocumentID { get; set; }
        string BARSDocumentCode { get; set; }
        System.Guid? BARSPrevRevisionDocumentID { get; set; }
        string BARSPrevRevisionDocumentCode { get; set; }
        int? BARSRevisionNumber { get; set; }
        System.DateTime BARSTransactionDate { get; set; }
        System.Guid CollectorID { get; set; }
        string CollectorCode { get; set; }
        string CollectorName { get; set; }
        string Collector { get; set; }
        bool IsCollectorHeadOffice { get; set; }
        System.Guid? CollectorSiteID { get; set; }
        string CollectorSiteCode { get; set; }
        string CollectorSiteName { get; set; }
        string CollectorSite { get; set; }
        int? CollectorAreaID { get; set; }
        string CollectorAreaCode { get; set; }
        string CollectorAreaName { get; set; }
        string CollectorArea { get; set; }
        int? CollectorRegionID { get; set; }
        string CollectorRegionCode { get; set; }
        string CollectorRegionName { get; set; }
        string CollectorRegion { get; set; }
        int? CollectorTerritoryID { get; set; }
        string CollectorTerritoryCode { get; set; }
        string CollectorTerritoryName { get; set; }
        string CollectorTerritory { get; set; }
        int? CollectorCompanyID { get; set; }
        string CollectorCompanyCode { get; set; }
        string CollectorCompanyName { get; set; }
        string CollectorCompany { get; set; }
        int? CollectorSiteDistributionTypeID { get; set; }
        string CollectorSiteDistributionTypeName { get; set; }
        bool? IsCollectorSiteProductLotCodeEntryRequired { get; set; }
        System.Guid? RefCollectorID { get; set; }
        string RefCollectorCode { get; set; }
        string RefCollectorName { get; set; }
        string RefCollector { get; set; }
        int BARSPrintCount { get; set; }
        System.DateTime? BARSLastPrintedDate { get; set; }
        int BARSDocumentStatusID { get; set; }
        string BARSDocumentStatusName { get; set; }
        System.DateTime? BARSPostedDate { get; set; }
        System.DateTime BARSCreatedDate { get; set; }
        int? BARSCreatedByUserID { get; set; }
        string BARSCreatedByUserName { get; set; }
        System.DateTime? BARSModifiedDate { get; set; }
        int? BARSModifiedByUserID { get; set; }
        string BARSModifiedByUserName { get; set; }

        #endregion

        #region Methods
        
        void CopyFrom(IvInvoiceBillAndReceiptStatement obj);
        
        #endregion
        
    }

}
