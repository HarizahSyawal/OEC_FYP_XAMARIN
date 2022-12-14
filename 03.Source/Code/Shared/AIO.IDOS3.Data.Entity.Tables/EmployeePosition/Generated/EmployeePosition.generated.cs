// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:50
// Description   : EmployeePosition partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'EmployeePosition.cs'
//       up to one level of this file location inside 'EmployeePosition' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{
    
    public partial class EmployeePosition : IEmployeePosition
    {                
        
        #region Implements IEmployeePosition

        public int PositionID { get; set; }            
        public System.Guid EmployeeID { get; set; }            
        public System.DateTime CreatedDate { get; set; }            
        public int? CreatedByUserID { get; set; }            

        
        
        public void CopyFrom(IEmployeePosition obj)
        {
            PositionID = obj.PositionID;
            EmployeeID = obj.EmployeeID;
            CreatedDate = obj.CreatedDate;
            CreatedByUserID = obj.CreatedByUserID;
        }
        
        #endregion
        
    }

}
