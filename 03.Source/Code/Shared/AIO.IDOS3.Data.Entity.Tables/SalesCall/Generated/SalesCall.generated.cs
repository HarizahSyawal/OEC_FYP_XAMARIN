﻿// ===================================================================================
// Author        : System
// Created date  : 25 Sep 2020 00:09:50
// Description   : SalesCall partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SalesCall.cs'
//       up to one level of this file location inside 'SalesCall' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class SalesCall : ISalesCall
    {                
        
        #region Implements ISalesCall

        public System.Guid ID { get; set; }            
        public System.Guid ActivityID { get; set; }            
        public System.Guid CustomerID { get; set; }            
        public bool IsInRoute { get; set; }            
        public System.DateTime CheckedInTime { get; set; }            
        public double? CheckedInLongitude { get; set; }
        public double? CheckedInLatitude { get; set; }
        public System.DateTime? CheckedOutTime { get; set; }            
        public double? CheckedOutLongitude { get; set; }
        public double? CheckedOutLatitude { get; set; }
        public System.DateTime FirstCheckedInTime { get; set; }            
        public double? FirstCheckedInLongitude { get; set; }
        public double? FirstCheckedInLatitude { get; set; }
        public System.DateTime? FirstCheckedOutTime { get; set; }            
        public double? FirstCheckedOutLongitude { get; set; }
        public double? FirstCheckedOutLatitude { get; set; }
        public int? NoSalesReasonID { get; set; }            
        public string ClosedOutletPhotoEvidence { get; set; }            
        public string MerchandiseDisplayActivityNote { get; set; }            
        public string MerchandiseDisplayActivityPhotoBefore { get; set; }            
        public string MerchandiseDisplayActivityPhotoAfter { get; set; }            
        public string PromotionalMaterialActivityNote { get; set; }            
        public string PromotionalMaterialActivityPhotoBefore { get; set; }            
        public string PromotionalMaterialActivityPhotoAfter { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        
        
        
        public void CopyFrom(ISalesCall obj)
        {
            ID = obj.ID;
            ActivityID = obj.ActivityID;
            CustomerID = obj.CustomerID;
            IsInRoute = obj.IsInRoute;
            CheckedInTime = obj.CheckedInTime;
            CheckedInLongitude = obj.CheckedInLongitude;
            CheckedInLatitude = obj.CheckedInLatitude;
            CheckedOutTime = obj.CheckedOutTime;
            CheckedOutLongitude = obj.CheckedOutLongitude;
            CheckedOutLatitude = obj.CheckedOutLatitude;
            FirstCheckedInTime = obj.FirstCheckedInTime;
            FirstCheckedInLongitude = obj.FirstCheckedInLongitude;
            FirstCheckedInLatitude = obj.FirstCheckedInLatitude;
            FirstCheckedOutTime = obj.FirstCheckedOutTime;
            FirstCheckedOutLongitude = obj.FirstCheckedOutLongitude;
            FirstCheckedOutLatitude = obj.FirstCheckedOutLatitude;
            NoSalesReasonID = obj.NoSalesReasonID;
            ClosedOutletPhotoEvidence = obj.ClosedOutletPhotoEvidence;
            MerchandiseDisplayActivityNote = obj.MerchandiseDisplayActivityNote;
            MerchandiseDisplayActivityPhotoBefore = obj.MerchandiseDisplayActivityPhotoBefore;
            MerchandiseDisplayActivityPhotoAfter = obj.MerchandiseDisplayActivityPhotoAfter;
            PromotionalMaterialActivityNote = obj.PromotionalMaterialActivityNote;
            PromotionalMaterialActivityPhotoBefore = obj.PromotionalMaterialActivityPhotoBefore;
            PromotionalMaterialActivityPhotoAfter = obj.PromotionalMaterialActivityPhotoAfter;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}
