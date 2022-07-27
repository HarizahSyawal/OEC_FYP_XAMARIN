﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:16
// Description   : vSalesOrderSummaryEntityTypeConfig class.
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

    public class vSalesOrderSummaryEntityTypeConfig : IEntityTypeConfiguration<vSalesOrderSummary>, IEdmEntityConfiguration<vSalesOrderSummary>
    {

        #region Implements IEntityTypeConfiguration<vSalesOrderSummary>

        public void Configure(EntityTypeBuilder<vSalesOrderSummary> builder)
        {
            InternalConfigure(builder);

            builder.HasOne(p => p.Parent)
                .WithMany(q => q.ChildSummaries)
                .HasForeignKey(p => p.DocumentID)
                .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<vSalesOrderSummary>

        public string EntitySetName { get; } = "vSalesOrderSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vSalesOrderSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vSalesOrderSummary
        {
            builder.ToTable("vSalesOrderSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vSalesOrderSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        #endregion

    }

}
