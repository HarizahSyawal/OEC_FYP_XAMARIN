﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:08
// Description   : OrganizationUnitEntityTypeConfig class.
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

    public class OrganizationUnitEntityTypeConfig : IEntityTypeConfiguration<OrganizationUnit>
    {

        #region Implements IEntityTypeConfiguration<OrganizationUnit>
        
        public void Configure(EntityTypeBuilder<OrganizationUnit> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : OrganizationUnit
        {
            builder.ToTable("OrganizationUnit");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
        }
        
        #endregion

    }

}