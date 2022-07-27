﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:12
// Description   : SalesmanTargetEntityTypeConfig class.
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

    public class SalesmanTargetEntityTypeConfig : IEntityTypeConfiguration<SalesmanTarget>
    {

        #region Implements IEntityTypeConfiguration<SalesmanTarget>
        
        public void Configure(EntityTypeBuilder<SalesmanTarget> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : SalesmanTarget
        {
            builder.ToTable("SalesmanTarget");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SalesmanID, p.PeriodID });
        }
        
        #endregion

    }

}