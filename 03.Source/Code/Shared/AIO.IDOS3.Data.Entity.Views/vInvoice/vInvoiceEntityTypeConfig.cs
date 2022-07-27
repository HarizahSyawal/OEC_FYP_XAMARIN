﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:01
// Description   : vInvoiceEntityTypeConfig class.
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

    public class vInvoiceEntityTypeConfig : IEntityTypeConfiguration<vInvoice>, IEdmEntityConfiguration<vInvoice>
    {

        #region Implements IEntityTypeConfiguration<vInvoice>
        
        public void Configure(EntityTypeBuilder<vInvoice> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vInvoice>

        public string EntitySetName { get; } = "vInvoices";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vInvoice> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vInvoice
        {
            builder.ToTable("vInvoice");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vInvoice
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}