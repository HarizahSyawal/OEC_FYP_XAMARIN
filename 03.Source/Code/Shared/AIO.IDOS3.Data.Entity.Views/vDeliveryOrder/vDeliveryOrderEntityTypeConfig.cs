﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:58
// Description   : vDeliveryOrderEntityTypeConfig class.
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

    public class vDeliveryOrderEntityTypeConfig : IEntityTypeConfiguration<vDeliveryOrder>, IEdmEntityConfiguration<vDeliveryOrder>
    {

        #region Implements IEntityTypeConfiguration<vDeliveryOrder>
        
        public void Configure(EntityTypeBuilder<vDeliveryOrder> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vDeliveryOrder>

        public string EntitySetName { get; } = "vDeliveryOrders";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vDeliveryOrder> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vDeliveryOrder
        {
            builder.ToTable("vDeliveryOrder");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vDeliveryOrder
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }

        #endregion

    }

}