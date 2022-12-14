// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:51
// Description   : MerchandiseDisplayActivity partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'MerchandiseDisplayActivity.cs'
//       up to one level of this file location inside 'MerchandiseDisplayActivity' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class MerchandiseDisplayActivity : IMerchandiseDisplayActivity
    {                
        
        #region Implements IMerchandiseDisplayActivity

        public System.Guid ID { get; set; }            
        public System.DateTime ActivityDate { get; set; }            
        public System.Guid SalesmanCallID { get; set; }            
        public string AttachmentFile { get; set; }            
        public System.DateTime? CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            

        
        
        public void CopyFrom(IMerchandiseDisplayActivity obj)
        {
            ID = obj.ID;
            ActivityDate = obj.ActivityDate;
            SalesmanCallID = obj.SalesmanCallID;
            AttachmentFile = obj.AttachmentFile;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
        }
        
        #endregion
        
    }

}
