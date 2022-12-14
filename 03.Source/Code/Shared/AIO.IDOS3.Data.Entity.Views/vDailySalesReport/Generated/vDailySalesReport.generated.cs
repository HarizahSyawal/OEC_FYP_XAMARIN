// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:58
// Description   : vDailySalesReport partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vDailySalesReport.cs'
//       up to one level of this file location inside 'vDailySalesReport' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vDailySalesReport : BaseEntityType, IvDailySalesReport
    {                
        
        #region Implements IvDailySalesReport

        public string RowArea1 { get; set; }
        public string RowArea2 { get; set; }
        public string RowArea3 { get; set; }
        public string ColumnArea1 { get; set; }
        public string ColumnArea2 { get; set; }
        public string ColumnArea3 { get; set; }
        public string ColumnArea4 { get; set; }
        public double? DataArea1 { get; set; }
        public double? DataArea2 { get; set; }
        public double? DataArea3 { get; set; }
        public double? DataArea4 { get; set; }
        public double? DataArea5 { get; set; }
        public double? DataArea6 { get; set; }
        
        
        
        public void CopyFrom(IvDailySalesReport obj)
        {
            RowArea1 = obj.RowArea1;
            RowArea2 = obj.RowArea2;
            RowArea3 = obj.RowArea3;
            ColumnArea1 = obj.ColumnArea1;
            ColumnArea2 = obj.ColumnArea2;
            ColumnArea3 = obj.ColumnArea3;
            ColumnArea4 = obj.ColumnArea4;
            DataArea1 = obj.DataArea1;
            DataArea2 = obj.DataArea2;
            DataArea3 = obj.DataArea3;
            DataArea4 = obj.DataArea4;
            DataArea5 = obj.DataArea5;
            DataArea6 = obj.DataArea6;
        }
        
        #endregion

    }

}
