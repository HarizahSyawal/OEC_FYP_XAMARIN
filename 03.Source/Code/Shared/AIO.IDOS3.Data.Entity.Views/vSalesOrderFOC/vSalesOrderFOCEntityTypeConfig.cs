﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:13
// Description   : vSalesOrderFOCEntityTypeConfig class.
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

    public class vSalesOrderFOCEntityTypeConfig : IEntityTypeConfiguration<vSalesOrderFOC>, IEdmEntityConfiguration<vSalesOrderFOC>
    {

        #region Implements IEntityTypeConfiguration<vSalesOrderFOC>
        
        public void Configure(EntityTypeBuilder<vSalesOrderFOC> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vSalesOrderFOC>

        public string EntitySetName { get; } = "vSalesOrderFOCs";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vSalesOrderFOC> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vSalesOrderFOC
        {
            builder.ToTable("vSalesOrderFOC");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vSalesOrderFOC
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}