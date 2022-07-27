﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:24
// Description   : StockReturnForDisposalDetailsEntityTypeConfig class.
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

    public class StockReturnForDisposalDetailsEntityTypeConfig : IEntityTypeConfiguration<StockReturnForDisposalDetails>
    {

        #region Implements IEntityTypeConfiguration<StockReturnForDisposalDetails>
        
        public void Configure(EntityTypeBuilder<StockReturnForDisposalDetails> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : StockReturnForDisposalDetails
        {
            builder.ToTable("StockReturnForDisposalDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }
        
        #endregion

    }

}
