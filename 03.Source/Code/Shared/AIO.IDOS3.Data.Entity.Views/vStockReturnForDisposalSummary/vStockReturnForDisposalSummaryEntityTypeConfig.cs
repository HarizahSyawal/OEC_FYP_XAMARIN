﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:35
// Description   : vStockReturnForDisposalSummaryEntityTypeConfig class.
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

    public class vStockReturnForDisposalSummaryEntityTypeConfig : IEntityTypeConfiguration<vStockReturnForDisposalSummary>, IEdmEntityConfiguration<vStockReturnForDisposalSummary>
    {

        #region Implements IEntityTypeConfiguration<vStockReturnForDisposalSummary>
        
        public void Configure(EntityTypeBuilder<vStockReturnForDisposalSummary> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReturnForDisposalSummary>

        public string EntitySetName { get; } = "vStockReturnForDisposalSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReturnForDisposalSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReturnForDisposalSummary
        {
            builder.ToTable("vStockReturnForDisposalSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReturnForDisposalSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        #endregion

    }

}
