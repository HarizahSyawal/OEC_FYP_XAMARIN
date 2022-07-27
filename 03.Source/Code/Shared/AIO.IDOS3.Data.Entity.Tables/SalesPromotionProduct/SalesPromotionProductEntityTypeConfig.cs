﻿// ===================================================================================
// Author        : System
// Created date  : 24 Sep 2020 03:19:46
// Description   : SalesPromotionProductEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{

    public class SalesPromotionProductEntityTypeConfig : IEntityTypeConfiguration<SalesPromotionProduct>
    {

        #region Implements IEntityTypeConfiguration<SalesPromotionProduct>
        
        public void Configure(EntityTypeBuilder<SalesPromotionProduct> builder)
        {
            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SalesPromotionID, p.ProductID });
        }
        
        #endregion

    }

}
