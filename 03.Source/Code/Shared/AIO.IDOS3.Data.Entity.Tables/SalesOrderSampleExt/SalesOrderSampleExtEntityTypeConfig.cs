﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:15
// Description   : SalesOrderSampleExtEntityTypeConfig class.
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

    public class SalesOrderSampleExtEntityTypeConfig : IEntityTypeConfiguration<SalesOrderSampleExt>
    {

        #region Implements IEntityTypeConfiguration<SalesOrderSampleExt>
        
        public void Configure(EntityTypeBuilder<SalesOrderSampleExt> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : SalesOrderSampleExt
        {
            builder.ToTable("SalesOrderSampleExt");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        #endregion

    }

}