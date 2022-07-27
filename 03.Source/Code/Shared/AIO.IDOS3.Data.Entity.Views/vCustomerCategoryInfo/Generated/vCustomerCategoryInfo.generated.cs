﻿// ===================================================================================
// Author        : System
// Created date  : 31 Aug 2020 20:35:56
// Description   : vCustomerCategoryInfo partial class.
//
// NOTE: This file is generated by system. Please do not modify this file.
//       Consider regenerate or modify through partial class. If required,
//       a partial class should be created as 'vCustomerCategoryInfo.cs'
//       up to one level of this file location inside 'vCustomerCategoryInfo' folder.
// ===================================================================================

using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
        
    public partial class vCustomerCategoryInfo : BaseEntityType, IvCustomerCategoryInfo
    {                
        
        #region Implements IvCustomerCategoryInfo

        public System.Guid CustomerID { get; set; }
        public int? Category1ID { get; set; }
        public string Category1Code { get; set; }
        public string Category1Name { get; set; }
        public string Category1 { get; set; }
        public int? Category2ID { get; set; }
        public string Category2Code { get; set; }
        public string Category2Name { get; set; }
        public string Category2 { get; set; }
        public int? Category3ID { get; set; }
        public string Category3Code { get; set; }
        public string Category3Name { get; set; }
        public string Category3 { get; set; }
        public int? Category4ID { get; set; }
        public string Category4Code { get; set; }
        public string Category4Name { get; set; }
        public string Category4 { get; set; }
        public int? Category5ID { get; set; }
        public string Category5Code { get; set; }
        public string Category5Name { get; set; }
        public string Category5 { get; set; }
        public int? Category6ID { get; set; }
        public int? Category6Code { get; set; }
        public int? Category6Name { get; set; }
        public int? Category6 { get; set; }
        public int? Category7ID { get; set; }
        public int? Category7Code { get; set; }
        public int? Category7Name { get; set; }
        public int? Category7 { get; set; }
        public int? Category8ID { get; set; }
        public int? Category8Code { get; set; }
        public int? Category8Name { get; set; }
        public int? Category8 { get; set; }
        public int? Category9ID { get; set; }
        public int? Category9Code { get; set; }
        public int? Category9Name { get; set; }
        public int? Category9 { get; set; }
        public int? Category10ID { get; set; }
        public int? Category10Code { get; set; }
        public int? Category10Name { get; set; }
        public int? Category10 { get; set; }
        
        
        
        public void CopyFrom(IvCustomerCategoryInfo obj)
        {
            CustomerID = obj.CustomerID;
            Category1ID = obj.Category1ID;
            Category1Code = obj.Category1Code;
            Category1Name = obj.Category1Name;
            Category1 = obj.Category1;
            Category2ID = obj.Category2ID;
            Category2Code = obj.Category2Code;
            Category2Name = obj.Category2Name;
            Category2 = obj.Category2;
            Category3ID = obj.Category3ID;
            Category3Code = obj.Category3Code;
            Category3Name = obj.Category3Name;
            Category3 = obj.Category3;
            Category4ID = obj.Category4ID;
            Category4Code = obj.Category4Code;
            Category4Name = obj.Category4Name;
            Category4 = obj.Category4;
            Category5ID = obj.Category5ID;
            Category5Code = obj.Category5Code;
            Category5Name = obj.Category5Name;
            Category5 = obj.Category5;
            Category6ID = obj.Category6ID;
            Category6Code = obj.Category6Code;
            Category6Name = obj.Category6Name;
            Category6 = obj.Category6;
            Category7ID = obj.Category7ID;
            Category7Code = obj.Category7Code;
            Category7Name = obj.Category7Name;
            Category7 = obj.Category7;
            Category8ID = obj.Category8ID;
            Category8Code = obj.Category8Code;
            Category8Name = obj.Category8Name;
            Category8 = obj.Category8;
            Category9ID = obj.Category9ID;
            Category9Code = obj.Category9Code;
            Category9Name = obj.Category9Name;
            Category9 = obj.Category9;
            Category10ID = obj.Category10ID;
            Category10Code = obj.Category10Code;
            Category10Name = obj.Category10Name;
            Category10 = obj.Category10;
        }
        
        #endregion

    }

}