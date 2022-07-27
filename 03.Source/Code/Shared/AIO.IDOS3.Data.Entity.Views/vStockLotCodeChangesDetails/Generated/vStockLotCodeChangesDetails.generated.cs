﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:34
// Description   : vStockLotCodeChangesDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vStockLotCodeChangesDetails.cs'
//       up to one level of this file location inside 'vStockLotCodeChangesDetails' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vStockLotCodeChangesDetails : BaseEntityType, IvStockLotCodeChangesDetails
    {                
        
        #region Implements IvStockLotCodeChangesDetails

        public System.Guid DocumentID { get; set; }
        public int ProductID { get; set; }
        public int OldProductLotID { get; set; }
        public int NewProductLotID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Product { get; set; }
        public int ProductBrandID { get; set; }
        public string ProductBrandCode { get; set; }
        public string ProductBrandName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductShortName { get; set; }
        public int? ProductUOMLID { get; set; }
        public int? ProductUOMMID { get; set; }
        public int? ProductUOMSID { get; set; }
        public string ProductUOMLName { get; set; }
        public string ProductUOMMName { get; set; }
        public string ProductUOMSName { get; set; }
        public double ProductWeight { get; set; }
        public int? ProductDimensionL { get; set; }
        public int? ProductDimensionW { get; set; }
        public int? ProductDimensionH { get; set; }
        public int? ProductConversionL { get; set; }
        public int? ProductConversionM { get; set; }
        public int ProductConversionS { get; set; }
        public string OldProductLotCode { get; set; }
        public System.DateTime? OldProductLotExpiredDate { get; set; }
        public string OldProductLot { get; set; }
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
        
        
        
        public void CopyFrom(IvStockLotCodeChangesDetails obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            OldProductLotID = obj.OldProductLotID;
            NewProductLotID = obj.NewProductLotID;
            ProductCode = obj.ProductCode;
            ProductName = obj.ProductName;
            Product = obj.Product;
            ProductBrandID = obj.ProductBrandID;
            ProductBrandCode = obj.ProductBrandCode;
            ProductBrandName = obj.ProductBrandName;
            ProductBrand = obj.ProductBrand;
            ProductShortName = obj.ProductShortName;
            ProductUOMLID = obj.ProductUOMLID;
            ProductUOMMID = obj.ProductUOMMID;
            ProductUOMSID = obj.ProductUOMSID;
            ProductUOMLName = obj.ProductUOMLName;
            ProductUOMMName = obj.ProductUOMMName;
            ProductUOMSName = obj.ProductUOMSName;
            ProductWeight = obj.ProductWeight;
            ProductDimensionL = obj.ProductDimensionL;
            ProductDimensionW = obj.ProductDimensionW;
            ProductDimensionH = obj.ProductDimensionH;
            ProductConversionL = obj.ProductConversionL;
            ProductConversionM = obj.ProductConversionM;
            ProductConversionS = obj.ProductConversionS;
            OldProductLotCode = obj.OldProductLotCode;
            OldProductLotExpiredDate = obj.OldProductLotExpiredDate;
            OldProductLot = obj.OldProductLot;
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
