﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:36
// Description   : vStockReturnForSampleSummaryEntityTypeConfig class.
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

    public class vStockReturnForSampleSummaryEntityTypeConfig : IEntityTypeConfiguration<vStockReturnForSampleSummary>, IEdmEntityConfiguration<vStockReturnForSampleSummary>
    {

        #region Implements IEntityTypeConfiguration<vStockReturnForSampleSummary>
        
        public void Configure(EntityTypeBuilder<vStockReturnForSampleSummary> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReturnForSampleSummary>

        public string EntitySetName { get; } = "vStockReturnForSampleSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReturnForSampleSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReturnForSampleSummary
        {
            builder.ToTable("vStockReturnForSampleSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReturnForSampleSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        #endregion

    }

}
