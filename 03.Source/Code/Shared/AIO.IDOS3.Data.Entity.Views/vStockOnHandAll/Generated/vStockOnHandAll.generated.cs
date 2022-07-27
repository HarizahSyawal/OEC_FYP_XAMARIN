﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:36
// Description   : vStockOnHandAll partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vStockOnHandAll.cs'
//       up to one level of this file location inside 'vStockOnHandAll' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vStockOnHandAll : BaseEntityType, IvStockOnHandAll
    {                
        
        #region Implements IvStockOnHandAll

        public System.Guid WarehouseID { get; set; }
        public int ProductID { get; set; }
        public int ProductLotID { get; set; }
        public int QtyPeriodOnHandGood { get; set; }
        public int QtyPeriodOnHandHold { get; set; }
        public int QtyPeriodOnHandBad { get; set; }
        public int QtyTransactionGood { get; set; }
        public int QtyTransactionHold { get; set; }
        public int QtyTransactionBad { get; set; }
        public int QtyReservedGood { get; set; }
        public int QtyReservedHold { get; set; }
        public int QtyReservedBad { get; set; }
        public int QtyInTransitGood { get; set; }
        public int QtyInTransitHold { get; set; }
        public int QtyInTransitBad { get; set; }
        public int QtyOnHandGood { get; set; }
        public int QtyOnHandHold { get; set; }
        public int QtyOnHandBad { get; set; }
        public int QtyInWarehouseGood { get; set; }
        public int QtyInWarehouseHold { get; set; }
        public int QtyInWarehouseBad { get; set; }
        public int QtyOwnedGood { get; set; }
        public int QtyOwnedHold { get; set; }
        public int QtyOwnedBad { get; set; }
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
        public string ProductLotCode { get; set; }
        public System.DateTime? ProductLotExpiredDate { get; set; }
        public string ProductLot { get; set; }
        
        
        
        public void CopyFrom(IvStockOnHandAll obj)
        {
            WarehouseID = obj.WarehouseID;
            ProductID = obj.ProductID;
            ProductLotID = obj.ProductLotID;
            QtyPeriodOnHandGood = obj.QtyPeriodOnHandGood;
            QtyPeriodOnHandHold = obj.QtyPeriodOnHandHold;
            QtyPeriodOnHandBad = obj.QtyPeriodOnHandBad;
            QtyTransactionGood = obj.QtyTransactionGood;
            QtyTransactionHold = obj.QtyTransactionHold;
            QtyTransactionBad = obj.QtyTransactionBad;
            QtyReservedGood = obj.QtyReservedGood;
            QtyReservedHold = obj.QtyReservedHold;
            QtyReservedBad = obj.QtyReservedBad;
            QtyInTransitGood = obj.QtyInTransitGood;
            QtyInTransitHold = obj.QtyInTransitHold;
            QtyInTransitBad = obj.QtyInTransitBad;
            QtyOnHandGood = obj.QtyOnHandGood;
            QtyOnHandHold = obj.QtyOnHandHold;
            QtyOnHandBad = obj.QtyOnHandBad;
            QtyInWarehouseGood = obj.QtyInWarehouseGood;
            QtyInWarehouseHold = obj.QtyInWarehouseHold;
            QtyInWarehouseBad = obj.QtyInWarehouseBad;
            QtyOwnedGood = obj.QtyOwnedGood;
            QtyOwnedHold = obj.QtyOwnedHold;
            QtyOwnedBad = obj.QtyOwnedBad;
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
            ProductLotCode = obj.ProductLotCode;
            ProductLotExpiredDate = obj.ProductLotExpiredDate;
            ProductLot = obj.ProductLot;
        }
        
        #endregion

    }

}
