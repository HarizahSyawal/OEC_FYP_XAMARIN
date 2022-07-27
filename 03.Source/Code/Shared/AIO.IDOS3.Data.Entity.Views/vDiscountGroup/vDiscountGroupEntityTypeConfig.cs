﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:59
// Description   : vDiscountGroupEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public class vDiscountGroupEntityTypeConfig : IEntityTypeConfiguration<vDiscountGroup>, IEdmEntityConfiguration<vDiscountGroup>
    {

        #region Implements IEntityTypeConfiguration<vDiscountGroup>
        
        public void Configure(EntityTypeBuilder<vDiscountGroup> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vDiscountGroup>

        public string EntitySetName { get; } = "vDiscountGroups";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vDiscountGroup> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vDiscountGroup
        {
            builder.ToTable("vDiscountGroup");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vDiscountGroup
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
