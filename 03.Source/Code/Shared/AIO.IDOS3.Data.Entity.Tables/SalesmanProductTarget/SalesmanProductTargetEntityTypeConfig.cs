﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:12
// Description   : SalesmanProductTargetEntityTypeConfig class.
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

    public class SalesmanProductTargetEntityTypeConfig : IEntityTypeConfiguration<SalesmanProductTarget>
    {

        #region Implements IEntityTypeConfiguration<SalesmanProductTarget>
        
        public void Configure(EntityTypeBuilder<SalesmanProductTarget> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : SalesmanProductTarget
        {
            builder.ToTable("SalesmanProductTarget");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SalesmanID, p.PeriodID, p.ProductID });
        }
        
        #endregion

    }

}