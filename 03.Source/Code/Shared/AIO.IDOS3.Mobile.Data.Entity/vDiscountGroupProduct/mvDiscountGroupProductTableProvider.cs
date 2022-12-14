// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 16:32:37
// Description   : mvDiscountGroupProductTableProvider partial class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public partial class mvDiscountGroupProductTableProvider : DataTableProvider<mvDiscountGroupProduct>
    {

        #region Methods

        public IList<mvDiscountGroupProduct> GetDataByDiscountGroupID(int discountGroupID)
        {
            return GetData().Where(p => (p.DiscountGroupID == discountGroupID)).ToList();
        }

        #endregion

    }

}
