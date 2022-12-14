// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:24
// Description   : StockReturnForSampleEntityTypeConfig class.
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

    public class StockReturnForSampleEntityTypeConfig : IEntityTypeConfiguration<StockReturnForSample>
    {

        #region Implements IEntityTypeConfiguration<StockReturnForSample>
        
        public void Configure(EntityTypeBuilder<StockReturnForSample> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : StockReturnForSample
        {
            builder.ToTable("StockReturnForSample");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        #endregion

    }

}
