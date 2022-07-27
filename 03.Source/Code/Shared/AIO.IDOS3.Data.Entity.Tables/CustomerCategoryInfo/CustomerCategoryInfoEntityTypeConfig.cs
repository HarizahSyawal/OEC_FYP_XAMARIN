﻿// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:11
// Description   : CustomerCategoryInfoEntityTypeConfig class.
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

    public class CustomerCategoryInfoEntityTypeConfig : IEntityTypeConfiguration<CustomerCategoryInfo>
    {

        #region Implements IEntityTypeConfiguration<CustomerCategoryInfo>
        
        public void Configure(EntityTypeBuilder<CustomerCategoryInfo> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : CustomerCategoryInfo
        {
            builder.ToTable("CustomerCategoryInfo");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID });
        }
        
        #endregion

    }

}
