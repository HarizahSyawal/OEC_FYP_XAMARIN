﻿// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:05
// Description   : CompanyAdditionalInfoEntityTypeConfig class.
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

    public class CompanyAdditionalInfoEntityTypeConfig : IEntityTypeConfiguration<CompanyAdditionalInfo>
    {

        #region Implements IEntityTypeConfiguration<CompanyAdditionalInfo>
        
        public void Configure(EntityTypeBuilder<CompanyAdditionalInfo> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : CompanyAdditionalInfo
        {
            builder.ToTable("CompanyAdditionalInfo");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.CompanyID });
        }
        
        #endregion

    }

}
