﻿// ===================================================================================
// Author        : System
// Created date  : 25 Sep 2020 00:10:37
// Description   : vCustomerStockRecordEntityTypeConfig class.
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

    public class vCustomerStockRecordEntityTypeConfig : IEntityTypeConfiguration<vCustomerStockRecord>, IEdmEntityConfiguration<vCustomerStockRecord>
    {

        #region Implements IEntityTypeConfiguration<vCustomerStockRecord>

        public void Configure(EntityTypeBuilder<vCustomerStockRecord> builder)
        {
            InternalConfigure(builder);

            builder.HasOne(p => p.ParentSalesCall)
                .WithMany(q => q.ChildCustomerStockRecords)
                .HasForeignKey(p => p.SalesCallID);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<vCustomerStockRecord>

        public string EntitySetName { get; } = "vCustomerStockRecords";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCustomerStockRecord> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCustomerStockRecord
        {
            builder.ToTable("vCustomerStockRecord");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID, p.RecordDateID, p.ProductID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCustomerStockRecord
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CustomerID, p.RecordDateID, p.ProductID });
        }

        #endregion

    }

}