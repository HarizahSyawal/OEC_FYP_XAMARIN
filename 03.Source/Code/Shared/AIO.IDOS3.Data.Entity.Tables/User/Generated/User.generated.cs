// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:28:09
// Description   : User partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'User.cs'
//       up to one level of this file location inside 'User' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class User : IUser
    {                
        
        #region Implements IUser

        public int ID { get; set; }            
        public string Name { get; set; }            
        public string Password { get; set; }            
        public bool IsHeadOffice { get; set; }            
        public System.Guid? SiteID { get; set; }            
        public int StatusID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            
        public System.DateTime? ModifiedDate { get; set; }            
        public int? ModifiedByUserID { get; set; }            
        public bool IsDeleted { get; set; }            

        
        
        public void CopyFrom(IUser obj)
        {
            ID = obj.ID;
            Name = obj.Name;
            Password = obj.Password;
            IsHeadOffice = obj.IsHeadOffice;
            SiteID = obj.SiteID;
            StatusID = obj.StatusID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            IsDeleted = obj.IsDeleted;
        }
        
        #endregion
        
    }

}
