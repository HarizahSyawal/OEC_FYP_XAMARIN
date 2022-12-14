// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:49
// Description   : IEmployee partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'IEmployee.cs'
//       up to one level of this file location inside 'Employee' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface IEmployee
    {                
        
        #region Properties
        
        System.Guid ID { get; set; }
        string Code { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int CompanyID { get; set; }
        bool Gender { get; set; }
        string BirthPlace { get; set; }
        System.DateTime BirthDate { get; set; }
        string CitizenIDCard { get; set; }
        string NationalityID { get; set; }
        System.DateTime RegisteredDate { get; set; }
        int? UserID { get; set; }
        string Photo { get; set; }
        int StatusID { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }
        bool IsDeleted { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(IEmployee obj);
        
        #endregion

    }

}
