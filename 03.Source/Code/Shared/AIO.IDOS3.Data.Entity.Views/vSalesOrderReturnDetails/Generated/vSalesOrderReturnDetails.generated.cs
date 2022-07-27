﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:25
// Description   : vSalesOrderReturnDetails partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vSalesOrderReturnDetails.cs'
//       up to one level of this file location inside 'vSalesOrderReturnDetails' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vSalesOrderReturnDetails : BaseEntityType, IvSalesOrderReturnDetails
    {                
        
        #region Implements IvSalesOrderReturnDetails

        public System.Guid DocumentID { get; set; }
        public int ProductID { get; set; }
        public int ProductLotID { get; set; }
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
        public int? QtyOnHand { get; set; }
        public int QtyConvL { get; set; }
        public int QtyConvM { get; set; }
        public int QtyConvS { get; set; }
        public int Qty { get; set; }
        public string QtyOrderConv { get; set; }
        public int? QtyOrder { get; set; }
        
        
        
        public void CopyFrom(IvSalesOrderReturnDetails obj)
        {
            DocumentID = obj.DocumentID;
            ProductID = obj.ProductID;
            ProductLotID = obj.ProductLotID;
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
            QtyOnHand = obj.QtyOnHand;
            QtyConvL = obj.QtyConvL;
            QtyConvM = obj.QtyConvM;
            QtyConvS = obj.QtyConvS;
            Qty = obj.Qty;
            QtyOrderConv = obj.QtyOrderConv;
            QtyOrder = obj.QtyOrder;
        }
        
        #endregion

    }

}
