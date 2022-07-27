﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:30
// Description   : vStockProductChangesSummaryEntityTypeConfig class.
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

    public class vStockProductChangesSummaryEntityTypeConfig : IEntityTypeConfiguration<vStockProductChangesSummary>, IEdmEntityConfiguration<vStockProductChangesSummary>
    {

        #region Implements IEntityTypeConfiguration<vStockProductChangesSummary>
        
        public void Configure(EntityTypeBuilder<vStockProductChangesSummary> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockProductChangesSummary>

        public string EntitySetName { get; } = "vStockProductChangesSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockProductChangesSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockProductChangesSummary
        {
            builder.ToTable("vStockProductChangesSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.OldProductID, p.OldProductLotID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockProductChangesSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.OldProductID, p.OldProductLotID });
        }

        #endregion

    }

}
