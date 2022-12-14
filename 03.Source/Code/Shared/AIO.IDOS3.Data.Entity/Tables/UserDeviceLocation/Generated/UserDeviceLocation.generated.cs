// ===================================================================================
// Author        : System
// Created date  : 12 Jan 2022 12:02:20
// Description   : UserDeviceLocation partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'UserDeviceLocation.cs'
//       up to one level of this file location inside 'UserDeviceLocation' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class UserDeviceLocation : IUserDeviceLocation
    {                
        
        #region Implements IUserDeviceLocation

        public System.Guid ID { get; set; }            
        public int UserID { get; set; }            
        public string IMEI { get; set; }            
        public double? Longitude { get; set; }            
        public double? Latitude { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        
        
        
        public void CopyFrom(IUserDeviceLocation obj)
        {
            ID = obj.ID;
            UserID = obj.UserID;
            IMEI = obj.IMEI;
            Longitude = obj.Longitude;
            Latitude = obj.Latitude;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
        }
        
        #endregion
        
    }

}
