﻿// ===================================================================================
// Author        : System
// Created date  : 23 Nov 2020 04:14:46
// Description   : mvUserDeviceLocation partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'mvUserDeviceLocation.cs'
//       up to one level of this file location inside 'vUserDeviceLocation' folder.
// ===================================================================================

using Microsoft.OData.Client;
using AIO.IDOS3.Data;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    
    [SQLite.Table("vUserDeviceLocation")]
    public partial class mvUserDeviceLocation : BaseEntityType, ImvUserDeviceLocation
    {                
        
        #region Implements ImvUserDeviceLocation

        [SQLiteNetExt.PrimaryKey]
        public System.Guid ID { get; set; }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public System.Guid? EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string Employee { get; set; }
        public System.Guid? SalesmanID { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public string Salesman { get; set; }
        public System.Guid? CollectorID { get; set; }
        public string CollectorCode { get; set; }
        public string CollectorName { get; set; }
        public string Collector { get; set; }
        public string IMEI { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }


        [IgnoreClientProperty]
        public System.DateTime? SyncDate { get; set; }

        [IgnoreClientProperty]
        public System.DateTime? LastSyncDate { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncStatus { get; set; }

        [IgnoreClientProperty]
        public int? LastSyncAttempts { get; set; }



        public void CopyFrom(IvUserDeviceLocation obj)
        {
            ID = obj.ID;
            UserID = obj.UserID;
            UserName = obj.UserName;
            EmployeeID = obj.EmployeeID;
            EmployeeCode = obj.EmployeeCode;
            Employee = obj.Employee;
            SalesmanID = obj.SalesmanID;
            SalesmanCode = obj.SalesmanCode;
            SalesmanName = obj.SalesmanName;
            Salesman = obj.Salesman;
            CollectorID = obj.CollectorID;
            CollectorCode = obj.CollectorCode;
            CollectorName = obj.CollectorName;
            Collector = obj.Collector;
            IMEI = obj.IMEI;
            Longitude = obj.Longitude;
            Latitude = obj.Latitude;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            CreatedByUserName = obj.CreatedByUserName;
        }
        
        #endregion

    }

}