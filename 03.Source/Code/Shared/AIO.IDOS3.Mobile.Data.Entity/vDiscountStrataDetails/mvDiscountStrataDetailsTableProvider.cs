﻿// ===================================================================================
// Author        : System
// Created date  : 09 Aug 2020 16:32:37
// Description   : mvDiscountStrataDetailsTableProvider partial class.
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

    public partial class mvDiscountStrataDetailsTableProvider : DataTableProvider<mvDiscountStrataDetails>
    {

        #region Methods

        public IList<mvDiscountStrataDetails> GetDataByStrataID(int strataID)
        {
            return GetData().Where(p => (p.StrataID == strataID)).ToList();
        }

        #endregion

    }

}
