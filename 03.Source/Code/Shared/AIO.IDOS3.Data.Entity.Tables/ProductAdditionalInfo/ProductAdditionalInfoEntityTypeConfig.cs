﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:09
// Description   : ProductAdditionalInfoEntityTypeConfig class.
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

    public class ProductAdditionalInfoEntityTypeConfig : IEntityTypeConfiguration<ProductAdditionalInfo>
    {

        #region Implements IEntityTypeConfiguration<ProductAdditionalInfo>
        
        public void Configure(EntityTypeBuilder<ProductAdditionalInfo> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : ProductAdditionalInfo
        {
            builder.ToTable("ProductAdditionalInfo");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ProductID });
        }
        
        #endregion

    }

}