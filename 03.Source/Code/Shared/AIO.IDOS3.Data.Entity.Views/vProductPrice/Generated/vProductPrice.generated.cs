﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:36:16
// Description   : vProductPrice partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vProductPrice.cs'
//       up to one level of this file location inside 'vProductPrice' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vProductPrice : BaseEntityType, IvProductPrice
    {                
        
        #region Implements IvProductPrice

        public int ID { get; set; }
        public string Code { get; set; }
        public int ProductID { get; set; }
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
        public int ProductStatusID { get; set; }
        public string ProductStatusName { get; set; }
        public string ProductAdditionalInfo1 { get; set; }
        public string ProductAdditionalInfo2 { get; set; }
        public string ProductAdditionalInfo3 { get; set; }
        public string ProductAdditionalInfo4 { get; set; }
        public string ProductAdditionalInfo5 { get; set; }
        public string ProductAdditionalInfo6 { get; set; }
        public string ProductAdditionalInfo7 { get; set; }
        public string ProductAdditionalInfo8 { get; set; }
        public string ProductAdditionalInfo9 { get; set; }
        public string ProductAdditionalInfo10 { get; set; }
        public System.DateTime? ValidDateFrom { get; set; }
        public System.DateTime? ValidDateTo { get; set; }
        public int PriceGroupID { get; set; }
        public string PriceGroupName { get; set; }
        public double GrossPrice { get; set; }
        public double TaxPercentage { get; set; }
        public double Price { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        public bool IsDeleted { get; set; }
        
        
        
        public void CopyFrom(IvProductPrice obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            ProductID = obj.ProductID;
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
            ProductStatusID = obj.ProductStatusID;
            ProductStatusName = obj.ProductStatusName;
            ProductAdditionalInfo1 = obj.ProductAdditionalInfo1;
            ProductAdditionalInfo2 = obj.ProductAdditionalInfo2;
            ProductAdditionalInfo3 = obj.ProductAdditionalInfo3;
            ProductAdditionalInfo4 = obj.ProductAdditionalInfo4;
            ProductAdditionalInfo5 = obj.ProductAdditionalInfo5;
            ProductAdditionalInfo6 = obj.ProductAdditionalInfo6;
            ProductAdditionalInfo7 = obj.ProductAdditionalInfo7;
            ProductAdditionalInfo8 = obj.ProductAdditionalInfo8;
            ProductAdditionalInfo9 = obj.ProductAdditionalInfo9;
            ProductAdditionalInfo10 = obj.ProductAdditionalInfo10;
            ValidDateFrom = obj.ValidDateFrom;
            ValidDateTo = obj.ValidDateTo;
            PriceGroupID = obj.PriceGroupID;
            PriceGroupName = obj.PriceGroupName;
            GrossPrice = obj.GrossPrice;
            TaxPercentage = obj.TaxPercentage;
            Price = obj.Price;
            StatusID = obj.StatusID;
            StatusName = obj.StatusName;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            ModifiedByUserName = obj.ModifiedByUserName;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion

    }

}
