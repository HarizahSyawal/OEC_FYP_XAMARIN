// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:45
// Description   : ICollectionRoutePlan partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ICollectionRoutePlan.cs'
//       up to one level of this file location inside 'CollectionRoutePlan' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ICollectionRoutePlan
    {                
        
        #region Properties
        
        System.Guid ReferenceID { get; set; }
        bool IsReferenceCustomerID { get; set; }
        bool Week1 { get; set; }
        bool Week2 { get; set; }
        bool Week3 { get; set; }
        bool Week4 { get; set; }
        bool Day1 { get; set; }
        bool Day2 { get; set; }
        bool Day3 { get; set; }
        bool Day4 { get; set; }
        bool Day5 { get; set; }
        bool Day6 { get; set; }
        bool Day7 { get; set; }
        System.DateTime CreatedDate { get; set; }
        int? CreatedByUserID { get; set; }
        System.DateTime? ModifiedDate { get; set; }
        int? ModifiedByUserID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ICollectionRoutePlan obj);
        
        #endregion

    }

}
