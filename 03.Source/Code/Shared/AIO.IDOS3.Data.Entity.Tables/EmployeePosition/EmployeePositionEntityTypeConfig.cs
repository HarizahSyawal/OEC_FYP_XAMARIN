﻿// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:15
// Description   : EmployeePositionEntityTypeConfig class.
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

    public class EmployeePositionEntityTypeConfig : IEntityTypeConfiguration<EmployeePosition>
    {

        #region Implements IEntityTypeConfiguration<EmployeePosition>
        
        public void Configure(EntityTypeBuilder<EmployeePosition> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : EmployeePosition
        {
            builder.ToTable("EmployeePosition");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.PositionID, p.EmployeeID });
        }
        
        #endregion

    }

}