// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:38
// Description   : vStockProductChangesDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vStockProductChangesDetails.cs'
//       up to one level of this file location inside 'vStockProductChangesDetails' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vStockProductChangesDetails : BaseEntityType, IvStockProductChangesDetails
    {                
        
        #region Implements IvStockProductChangesDetails

        public System.Guid DocumentID { get; set; }
        public int OldProductID { get; set; }
        public int OldProductLotID { get; set; }
        public int NewProductID { get; set; }
        public int NewProductLotID { get; set; }
        public string OldProductCode { get; set; }
        public string OldProductName { get; set; }
        public string OldProduct { get; set; }
        public int OldProductBrandID { get; set; }
        public string OldProductBrandCode { get; set; }
        public string OldProductBrandName { get; set; }
        public string OldProductBrand { get; set; }
        public string OldProductShortName { get; set; }
        public int? OldProductUOMLID { get; set; }
        public int? OldProductUOMMID { get; set; }
        public int? OldProductUOMSID { get; set; }
        public string OldProductUOMLName { get; set; }
        public string OldProductUOMMName { get; set; }
        public string OldProductUOMSName { get; set; }
        public double OldProductWeight { get; set; }
        public int? OldProductDimensionL { get; set; }
        public int? OldProductDimensionW { get; set; }
        public int? OldProductDimensionH { get; set; }
        public int? OldProductConversionL { get; set; }
        public int? OldProductConversionM { get; set; }
        public int OldProductConversionS { get; set; }
        public string OldProductLotCode { get; set; }
        public System.DateTime? OldProductLotExpiredDate { get; set; }
        public string OldProductLot { get; set; }
        public string NewProductCode { get; set; }
        public string NewProductName { get; set; }
        public string NewProduct { get; set; }
        public int NewProductBrandID { get; set; }
        public string NewProductBrandCode { get; set; }
        public string NewProductBrandName { get; set; }
        public string NewProductBrand { get; set; }
        public string NewProductShortName { get; set; }
        public int? NewProductUOMLID { get; set; }
        public int? NewProductUOMMID { get; set; }
        public int? NewProductUOMSID { get; set; }
        public string NewProductUOMLName { get; set; }
        public string NewProductUOMMName { get; set; }
        public string NewProductUOMSName { get; set; }
        public double NewProductWeight { get; set; }
        public int? NewProductDimensionL { get; set; }
        public int? NewProductDimensionW { get; set; }
        public int? NewProductDimensionH { get; set; }
        public int? NewProductConversionL { get; set; }
        public int? NewProductConversionM { get; set; }
        public int NewProductConversionS { get; set; }
        public string NewProductLotCode { get; set; }
        public System.DateTime? NewProductLotExpiredDate { get; set; }
        public string NewProductLot { get; set; }
        public int? QtyOnHandGood { get; set; }
        public int? QtyOnHandHold { get; set; }
        public int? QtyOnHandBad { get; set; }
        public int QtyConvLGood { get; set; }
        public int QtyConvMGood { get; set; }
        public int QtyConvSGood { get; set; }
        public int QtyConvLHold { get; set; }
        public int QtyConvMHold { get; set; }
        public int QtyConvSHold { get; set; }
        public int QtyConvLBad { get; set; }
        public int QtyConvMBad { get; set; }
        public int QtyConvSBad { get; set; }
        public int QtyGood { get; set; }
        public int QtyHold { get; set; }
        public int QtyBad { get; set; }
        public string QtyChangesConvGood { get; set; }
        public string QtyChangesConvHold { get; set; }
        public string QtyChangesConvBad { get; set; }
        public int? QtyChangesGood { get; set; }
        public int? QtyChangesHold { get; set; }
        public int? QtyChangesBad { get; set; }
        
        
        
        public void CopyFrom(IvStockProductChangesDetails obj)
        {
            DocumentID = obj.DocumentID;
            OldProductID = obj.OldProductID;
            OldProductLotID = obj.OldProductLotID;
            NewProductID = obj.NewProductID;
            NewProductLotID = obj.NewProductLotID;
            OldProductCode = obj.OldProductCode;
            OldProductName = obj.OldProductName;
            OldProduct = obj.OldProduct;
            OldProductBrandID = obj.OldProductBrandID;
            OldProductBrandCode = obj.OldProductBrandCode;
            OldProductBrandName = obj.OldProductBrandName;
            OldProductBrand = obj.OldProductBrand;
            OldProductShortName = obj.OldProductShortName;
            OldProductUOMLID = obj.OldProductUOMLID;
            OldProductUOMMID = obj.OldProductUOMMID;
            OldProductUOMSID = obj.OldProductUOMSID;
            OldProductUOMLName = obj.OldProductUOMLName;
            OldProductUOMMName = obj.OldProductUOMMName;
            OldProductUOMSName = obj.OldProductUOMSName;
            OldProductWeight = obj.OldProductWeight;
            OldProductDimensionL = obj.OldProductDimensionL;
            OldProductDimensionW = obj.OldProductDimensionW;
            OldProductDimensionH = obj.OldProductDimensionH;
            OldProductConversionL = obj.OldProductConversionL;
            OldProductConversionM = obj.OldProductConversionM;
            OldProductConversionS = obj.OldProductConversionS;
            OldProductLotCode = obj.OldProductLotCode;
            OldProductLotExpiredDate = obj.OldProductLotExpiredDate;
            OldProductLot = obj.OldProductLot;
            NewProductCode = obj.NewProductCode;
            NewProductName = obj.NewProductName;
            NewProduct = obj.NewProduct;
            NewProductBrandID = obj.NewProductBrandID;
            NewProductBrandCode = obj.NewProductBrandCode;
            NewProductBrandName = obj.NewProductBrandName;
            NewProductBrand = obj.NewProductBrand;
            NewProductShortName = obj.NewProductShortName;
            NewProductUOMLID = obj.NewProductUOMLID;
            NewProductUOMMID = obj.NewProductUOMMID;
            NewProductUOMSID = obj.NewProductUOMSID;
            NewProductUOMLName = obj.NewProductUOMLName;
            NewProductUOMMName = obj.NewProductUOMMName;
            NewProductUOMSName = obj.NewProductUOMSName;
            NewProductWeight = obj.NewProductWeight;
            NewProductDimensionL = obj.NewProductDimensionL;
            NewProductDimensionW = obj.NewProductDimensionW;
            NewProductDimensionH = obj.NewProductDimensionH;
            NewProductConversionL = obj.NewProductConversionL;
            NewProductConversionM = obj.NewProductConversionM;
            NewProductConversionS = obj.NewProductConversionS;
            NewProductLotCode = obj.NewProductLotCode;
            NewProductLotExpiredDate = obj.NewProductLotExpiredDate;
            NewProductLot = obj.NewProductLot;
            QtyOnHandGood = obj.QtyOnHandGood;
            QtyOnHandHold = obj.QtyOnHandHold;
            QtyOnHandBad = obj.QtyOnHandBad;
            QtyConvLGood = obj.QtyConvLGood;
            QtyConvMGood = obj.QtyConvMGood;
            QtyConvSGood = obj.QtyConvSGood;
            QtyConvLHold = obj.QtyConvLHold;
            QtyConvMHold = obj.QtyConvMHold;
            QtyConvSHold = obj.QtyConvSHold;
            QtyConvLBad = obj.QtyConvLBad;
            QtyConvMBad = obj.QtyConvMBad;
            QtyConvSBad = obj.QtyConvSBad;
            QtyGood = obj.QtyGood;
            QtyHold = obj.QtyHold;
            QtyBad = obj.QtyBad;
            QtyChangesConvGood = obj.QtyChangesConvGood;
            QtyChangesConvHold = obj.QtyChangesConvHold;
            QtyChangesConvBad = obj.QtyChangesConvBad;
            QtyChangesGood = obj.QtyChangesGood;
            QtyChangesHold = obj.QtyChangesHold;
            QtyChangesBad = obj.QtyChangesBad;
        }
        
        #endregion

    }

}
