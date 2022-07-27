﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvDiscountGroupProduct class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvDiscountGroupProduct : vDiscountGroupProduct, ImvDiscountGroupProduct
    {

        #region Properties

        public new mvDiscountGroup Parent { get; set; }
        public new mvDiscountStrata ExtendDiscountStrata1 { get; set; }
        public new mvDiscountStrata ExtendDiscountStrata2 { get; set; }
        public new mvDiscountStrata ExtendDiscountStrata3 { get; set; }
        public new mvDiscountStrata ExtendDiscountStrata4 { get; set; }
        public new mvDiscountStrata ExtendDiscountStrata5 { get; set; }
        public new mvDiscountStrata ExtendSpecialDiscountStrata1 { get; set; }
        public new mvDiscountStrata ExtendSpecialDiscountStrata2 { get; set; }
        public new mvDiscountStrata ExtendSpecialDiscountStrata3 { get; set; }
        public new mvDiscountStrata ExtendSpecialDiscountStrata4 { get; set; }
        public new mvDiscountStrata ExtendSpecialDiscountStrata5 { get; set; }

        #endregion

    }

}