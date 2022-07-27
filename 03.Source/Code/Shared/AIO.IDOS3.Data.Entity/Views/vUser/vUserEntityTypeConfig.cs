﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:38
// Description   : vUserEntityTypeConfig class.
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

    public class vUserEntityTypeConfig : IEntityTypeConfiguration<vUser>, IEdmEntityConfiguration<vUser>
    {

        #region Implements IEntityTypeConfiguration<vUser>
        
        public void Configure(EntityTypeBuilder<vUser> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vUser>

        public string EntitySetName { get; } = "vUsers";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vUser> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vUser
        {
            builder.ToTable("vUser");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vUser
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
