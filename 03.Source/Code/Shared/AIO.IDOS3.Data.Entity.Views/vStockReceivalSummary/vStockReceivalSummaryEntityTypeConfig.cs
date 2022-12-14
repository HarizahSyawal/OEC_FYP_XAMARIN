// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:32
// Description   : vStockReceivalSummaryEntityTypeConfig class.
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

    public class vStockReceivalSummaryEntityTypeConfig : IEntityTypeConfiguration<vStockReceivalSummary>, IEdmEntityConfiguration<vStockReceivalSummary>
    {

        #region Implements IEntityTypeConfiguration<vStockReceivalSummary>
        
        public void Configure(EntityTypeBuilder<vStockReceivalSummary> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReceivalSummary>

        public string EntitySetName { get; } = "vStockReceivalSummaries";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReceivalSummary> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReceivalSummary
        {
            builder.ToTable("vStockReceivalSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReceivalSummary
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID });
        }

        #endregion

    }

}
