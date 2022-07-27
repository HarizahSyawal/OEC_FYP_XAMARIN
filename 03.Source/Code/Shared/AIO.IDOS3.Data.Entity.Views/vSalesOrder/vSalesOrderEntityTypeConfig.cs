﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:12
// Description   : vSalesOrderEntityTypeConfig class.
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

    public class vSalesOrderEntityTypeConfig : IEntityTypeConfiguration<vSalesOrder>, IEdmEntityConfiguration<vSalesOrder>
    {

        #region Implements IEntityTypeConfiguration<vSalesOrder>
        
        public void Configure(EntityTypeBuilder<vSalesOrder> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vSalesOrder>

        public string EntitySetName { get; } = "vSalesOrders";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vSalesOrder> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vSalesOrder
        {
            builder.ToTable("vSalesOrder");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vSalesOrder
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}
