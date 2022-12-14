// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:52
// Description   : vCurrency partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCurrency.cs'
//       up to one level of this file location inside 'vCurrency' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCurrency : BaseEntityType, IvCurrency
    {                
        
        #region Implements IvCurrency

        public string ID { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string Numeric3Code { get; set; }
        public int DecimalDigit { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedByUserID { get; set; }
        public string ModifiedByUserName { get; set; }
        
        
        
        public void CopyFrom(IvCurrency obj)
        {
            ID = obj.ID;
            Name = obj.Name;
            Currency = obj.Currency;
            Numeric3Code = obj.Numeric3Code;
            DecimalDigit = obj.DecimalDigit;
            StatusID = obj.StatusID;
            StatusName = obj.StatusName;
            ModifiedDate = obj.ModifiedDate;
            ModifiedByUserID = obj.ModifiedByUserID;
            ModifiedByUserName = obj.ModifiedByUserName;
        }
        
        #endregion

    }

}
