﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:17
// Description   : SiteAddressEntityTypeConfig class.
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

    public class SiteAddressEntityTypeConfig : IEntityTypeConfiguration<SiteAddress>
    {

        #region Implements IEntityTypeConfiguration<SiteAddress>
        
        public void Configure(EntityTypeBuilder<SiteAddress> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : SiteAddress
        {
            builder.ToTable("SiteAddress");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.SiteID });
        }
        
        #endregion

    }

}
