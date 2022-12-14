// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:36
// Description   : vStockReturnSummaryEntityTypeConfig class.
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

    public class vStockReturnSummaryEntityTypeConfig : IEntityTypeConfiguration<vStockReturnSummary>, IEdmEntityConfiguration<vStockReturnSummary>
    {

        #region Implements IEntityTypeConfiguration<vStockReturnSummary>
        
        public void Configure(EntityTypeBuilder<vStockReturnSummary> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReturnSummary>

        public string EntitySetName { get; } = "vStockReturnSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReturnSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReturnSummary
        {
            builder.ToTable("vStockReturnSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReturnSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        #endregion

    }

}
