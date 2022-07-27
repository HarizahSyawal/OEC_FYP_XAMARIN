﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:13
// Description   : SalesOrderFOCExtEntityTypeConfig class.
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

    public class SalesOrderFOCExtEntityTypeConfig : IEntityTypeConfiguration<SalesOrderFOCExt>
    {

        #region Implements IEntityTypeConfiguration<SalesOrderFOCExt>
        
        public void Configure(EntityTypeBuilder<SalesOrderFOCExt> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : SalesOrderFOCExt
        {
            builder.ToTable("SalesOrderFOCExt");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        #endregion

    }

}