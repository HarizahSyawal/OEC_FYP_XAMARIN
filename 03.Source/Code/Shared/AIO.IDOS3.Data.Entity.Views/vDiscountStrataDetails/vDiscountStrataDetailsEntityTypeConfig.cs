﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:59
// Description   : vDiscountStrataDetailsEntityTypeConfig class.
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

    public class vDiscountStrataDetailsEntityTypeConfig : IEntityTypeConfiguration<vDiscountStrataDetails>, IEdmEntityConfiguration<vDiscountStrataDetails>
    {

        #region Implements IEntityTypeConfiguration<vDiscountStrataDetails>

        public void Configure(EntityTypeBuilder<vDiscountStrataDetails> builder)
        {
            InternalConfigure(builder);

            builder.HasOne(p => p.Parent)
                .WithMany(q => q.ChildDetails)
                .HasForeignKey(p => p.StrataID)
                .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<vDiscountStrataDetails>

        public string EntitySetName { get; } = "vDiscountStrataDetails";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vDiscountStrataDetails> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vDiscountStrataDetails
        {
            builder.ToTable("vDiscountStrataDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vDiscountStrataDetails
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}