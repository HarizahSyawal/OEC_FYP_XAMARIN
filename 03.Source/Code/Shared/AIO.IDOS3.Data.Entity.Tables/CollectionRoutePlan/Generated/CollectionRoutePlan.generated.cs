﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:45
// Description   : CollectionRoutePlan partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'CollectionRoutePlan.cs'
//       up to one level of this file location inside 'CollectionRoutePlan' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class CollectionRoutePlan : ICollectionRoutePlan
    {                
        
        #region Implements ICollectionRoutePlan

        public System.Guid ReferenceID { get; set; }            
        public bool IsReferenceCustomerID { get; set; }            
        public bool Week1 { get; set; }            
        public bool Week2 { get; set; }            
        public bool Week3 { get; set; }            
        public bool Week4 { get; set; }            
        public bool Day1 { get; set; }            
        public bool Day2 { get; set; }            
        public bool Day3 { get; set; }            
        public bool Day4 { get; set; }            
        public bool Day5 { get; set; }            
        public bool Day6 { get; set; }            
        public bool Day7 { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(ICollectionRoutePlan obj)
        {
            ReferenceID = obj.ReferenceID;
            IsReferenceCustomerID = obj.IsReferenceCustomerID;
            Week1 = obj.Week1;
            Week2 = obj.Week2;
            Week3 = obj.Week3;
            Week4 = obj.Week4;
            Day1 = obj.Day1;
            Day2 = obj.Day2;
            Day3 = obj.Day3;
            Day4 = obj.Day4;
            Day5 = obj.Day5;
            Day6 = obj.Day6;
            Day7 = obj.Day7;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}
