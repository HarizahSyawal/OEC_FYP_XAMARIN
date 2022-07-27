﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:20
// Description   : StockMatchingDetailsEntityTypeConfig class.
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

    public class StockMatchingDetailsEntityTypeConfig : IEntityTypeConfiguration<StockMatchingDetails>
    {

        #region Implements IEntityTypeConfiguration<StockMatchingDetails>
        
        public void Configure(EntityTypeBuilder<StockMatchingDetails> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : StockMatchingDetails
        {
            builder.ToTable("StockMatchingDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }
        
        #endregion

    }

}
