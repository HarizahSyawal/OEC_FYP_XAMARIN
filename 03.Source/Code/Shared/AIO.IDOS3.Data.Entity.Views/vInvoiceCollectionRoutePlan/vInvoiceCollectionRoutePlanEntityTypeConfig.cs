﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:02
// Description   : vInvoiceCollectionRoutePlanEntityTypeConfig class.
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

    public class vInvoiceCollectionRoutePlanEntityTypeConfig : IEntityTypeConfiguration<vInvoiceCollectionRoutePlan>, IEdmEntityConfiguration<vInvoiceCollectionRoutePlan>
    {

        #region Implements IEntityTypeConfiguration<vInvoiceCollectionRoutePlan>
        
        public void Configure(EntityTypeBuilder<vInvoiceCollectionRoutePlan> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vInvoiceCollectionRoutePlan>

        public string EntitySetName { get; } = "vInvoiceCollectionRoutePlans";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vInvoiceCollectionRoutePlan> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vInvoiceCollectionRoutePlan
        {
            builder.ToTable("vInvoiceCollectionRoutePlan");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vInvoiceCollectionRoutePlan
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}