﻿// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : SalesmanInitialCall partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'SalesmanInitialCall.cs'
//       up to one level of this file location inside 'SalesmanInitialCall' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class SalesmanInitialCall : ISalesmanInitialCall
    {                
        
        #region Implements ISalesmanInitialCall

        public System.Guid SalesmanID { get; set; }            
        public System.DateTime CallDate { get; set; }            
        public double StartOdometer { get; set; }            
        public double EndOdometer { get; set; }            
        public int EndOfDayPrintCount { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            

        
        
        public void CopyFrom(ISalesmanInitialCall obj)
        {
            SalesmanID = obj.SalesmanID;
            CallDate = obj.CallDate;
            StartOdometer = obj.StartOdometer;
            EndOdometer = obj.EndOdometer;
            EndOfDayPrintCount = obj.EndOfDayPrintCount;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }
        
        #endregion
        
    }

}