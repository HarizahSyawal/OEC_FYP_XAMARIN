// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:33
// Description   : vStockReceiveAsSampleSummaryEntityTypeConfig class.
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

    public class vStockReceiveAsSampleSummaryEntityTypeConfig : IEntityTypeConfiguration<vStockReceiveAsSampleSummary>, IEdmEntityConfiguration<vStockReceiveAsSampleSummary>
    {

        #region Implements IEntityTypeConfiguration<vStockReceiveAsSampleSummary>
        
        public void Configure(EntityTypeBuilder<vStockReceiveAsSampleSummary> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReceiveAsSampleSummary>

        public string EntitySetName { get; } = "vStockReceiveAsSampleSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReceiveAsSampleSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReceiveAsSampleSummary
        {
            builder.ToTable("vStockReceiveAsSampleSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReceiveAsSampleSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        #endregion

    }

}
