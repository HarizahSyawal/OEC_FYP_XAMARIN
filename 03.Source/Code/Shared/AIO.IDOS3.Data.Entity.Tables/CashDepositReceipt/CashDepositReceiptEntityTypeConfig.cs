﻿// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:01
// Description   : CashDepositReceiptEntityTypeConfig class.
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

    public class CashDepositReceiptEntityTypeConfig : IEntityTypeConfiguration<CashDepositReceipt>
    {

        #region Implements IEntityTypeConfiguration<CashDepositReceipt>
        
        public void Configure(EntityTypeBuilder<CashDepositReceipt> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : CashDepositReceipt
        {
            builder.ToTable("CashDepositReceipt");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        #endregion

    }

}
