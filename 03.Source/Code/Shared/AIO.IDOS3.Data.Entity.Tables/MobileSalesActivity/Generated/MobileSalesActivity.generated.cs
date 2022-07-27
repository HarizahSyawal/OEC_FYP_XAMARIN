﻿// ===================================================================================
// Author        : System
// Created date  : 25 Sep 2020 00:09:49
// Description   : MobileSalesActivity partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'MobileSalesActivity.cs'
//       up to one level of this file location inside 'MobileSalesActivity' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial class MobileSalesActivity : IMobileSalesActivity
    {

        #region Implements IMobileSalesActivity

        public System.Guid ID { get; set; }
        public System.Guid SalesmanID { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public System.DateTime StartTime { get; set; }
        public double? StartLongitude { get; set; }
        public double? StartLatitude { get; set; }
        public int? StartOdometer { get; set; }
        public System.DateTime? EndTime { get; set; }
        public double? EndLongitude { get; set; }
        public double? EndLatitude { get; set; }
        public int? EndOdometer { get; set; }
        public string DeviceIMEI { get; set; }
        public int StatusID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedByUserID { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }



        public void CopyFrom(IMobileSalesActivity obj)
        {
            ID = obj.ID;
            SalesmanID = obj.SalesmanID;
            ActivityDate = obj.ActivityDate;
            StartTime = obj.StartTime;
            StartLongitude = obj.StartLongitude;
            StartLatitude = obj.StartLatitude;
            StartOdometer = obj.StartOdometer;
            EndTime = obj.EndTime;
            EndLongitude = obj.EndLongitude;
            EndLatitude = obj.EndLatitude;
            EndOdometer = obj.EndOdometer;
            DeviceIMEI = obj.DeviceIMEI;
            StatusID = obj.StatusID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
        }

        #endregion

    }

}