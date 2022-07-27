﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:59
// Description   : vDiscountGroupProductEntityTypeConfig class.
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

    public class vDiscountGroupProductEntityTypeConfig : IEntityTypeConfiguration<vDiscountGroupProduct>, IEdmEntityConfiguration<vDiscountGroupProduct>
    {

        #region Implements IEntityTypeConfiguration<vDiscountGroupProduct>

        public void Configure(EntityTypeBuilder<vDiscountGroupProduct> builder)
        {
            InternalConfigure(builder);

            builder.HasOne(p => p.Parent)
                .WithMany(q => q.ChildProducts)
                .HasForeignKey(p => p.DiscountGroupID)
                .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<vDiscountGroupProduct>

        public string EntitySetName { get; } = "vDiscountGroupProducts";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vDiscountGroupProduct> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vDiscountGroupProduct
        {
            builder.ToTable("vDiscountGroupProduct");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DiscountGroupID, p.ProductID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vDiscountGroupProduct
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DiscountGroupID, p.ProductID });
        }

        #endregion

    }

}
