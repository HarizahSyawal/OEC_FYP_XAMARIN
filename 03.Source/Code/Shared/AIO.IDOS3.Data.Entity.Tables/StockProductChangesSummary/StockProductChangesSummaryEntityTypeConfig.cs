// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:21
// Description   : StockProductChangesSummaryEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{

    public class StockProductChangesSummaryEntityTypeConfig : IEntityTypeConfiguration<StockProductChangesSummary>
    {

        #region Implements IEntityTypeConfiguration<StockProductChangesSummary>
        
        public void Configure(EntityTypeBuilder<StockProductChangesSummary> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : StockProductChangesSummary
        {
            builder.ToTable("StockProductChangesSummary");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.OldProductID, p.OldProductLotID });
        }
        
        #endregion

    }

}
