﻿// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:10
// Description   : CustomerCategoryEntityTypeConfig class.
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

    public class CustomerCategoryEntityTypeConfig : IEntityTypeConfiguration<CustomerCategory>
    {

        #region Implements IEntityTypeConfiguration<CustomerCategory>
        
        public void Configure(EntityTypeBuilder<CustomerCategory> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : CustomerCategory
        {
            builder.ToTable("CustomerCategory");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
        }
        
        #endregion

    }

}
