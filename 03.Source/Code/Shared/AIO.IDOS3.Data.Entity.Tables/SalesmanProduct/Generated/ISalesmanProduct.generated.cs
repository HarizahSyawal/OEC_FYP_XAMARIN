// ===================================================================================
// Author        : System
// Created date  : 22 Aug 2020 19:27:54
// Description   : ISalesmanProduct partial interface.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial interface. If required,
//       a partial interface should be created as 'ISalesmanProduct.cs'
//       up to one level of this file location inside 'SalesmanProduct' folder.
// ===================================================================================

namespace AIO.IDOS3.Data.Entity
{

    public partial interface ISalesmanProduct
    {                
        
        #region Properties
        
        System.Guid SalesmanID { get; set; }
        int ProductID { get; set; }

        #endregion
        
        #region Methods
        
        void CopyFrom(ISalesmanProduct obj);
        
        #endregion

    }

}
