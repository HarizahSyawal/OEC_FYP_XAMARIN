﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:53
// Description   : vCompanyEntityTypeConfig class.
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

    public class vCompanyEntityTypeConfig : IEntityTypeConfiguration<vCompany>, IEdmEntityConfiguration<vCompany>
    {

        #region Implements IEntityTypeConfiguration<vCompany>
        
        public void Configure(EntityTypeBuilder<vCompany> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vCompany>

        public string EntitySetName { get; } = "vCompanies";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCompany> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCompany
        {
            builder.ToTable("vCompany");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCompany
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
