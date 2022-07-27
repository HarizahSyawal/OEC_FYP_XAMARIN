﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:21
// Description   : vStateProvinceEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public class vStateProvinceEntityTypeConfig : IEntityTypeConfiguration<vStateProvince>, IEdmEntityConfiguration<vStateProvince>
    {

        #region Implements IEntityTypeConfiguration<vStateProvince>
        
        public void Configure(EntityTypeBuilder<vStateProvince> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStateProvince>

        public string EntitySetName { get; } = "vStateProvinces";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStateProvince> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStateProvince
        {
            builder.ToTable("vStateProvince");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStateProvince
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}