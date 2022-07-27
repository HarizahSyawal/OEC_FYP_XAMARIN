﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:52
// Description   : Product partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'Product.cs'
//       up to one level of this file location inside 'Product' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class Product : IProduct
    {                
        
        #region Implements IProduct

        public int ID { get; set; }            
        public string Code { get; set; }            
        public string Name { get; set; }            
        public int BrandID { get; set; }            
        public string ShortName { get; set; }            
        public int? UOMLID { get; set; }            
        public int? UOMMID { get; set; }            
        public int? UOMSID { get; set; }            
        public double Weight { get; set; }            
        public int? DimensionL { get; set; }            
        public int? DimensionW { get; set; }            
        public int? DimensionH { get; set; }            
        public int? ConversionL { get; set; }            
        public int? ConversionM { get; set; }            
        public int ConversionS { get; set; }            
        public int ChangeValidationID { get; set; }            
        public int StatusID { get; set; }            
        public string SAPCode { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(IProduct obj)
        {
            ID = obj.ID;
            Code = obj.Code;
            Name = obj.Name;
            BrandID = obj.BrandID;
            ShortName = obj.ShortName;
            UOMLID = obj.UOMLID;
            UOMMID = obj.UOMMID;
            UOMSID = obj.UOMSID;
            Weight = obj.Weight;
            DimensionL = obj.DimensionL;
            DimensionW = obj.DimensionW;
            DimensionH = obj.DimensionH;
            ConversionL = obj.ConversionL;
            ConversionM = obj.ConversionM;
            ConversionS = obj.ConversionS;
            ChangeValidationID = obj.ChangeValidationID;
            StatusID = obj.StatusID;
            SAPCode = obj.SAPCode;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion
        
    }

}
