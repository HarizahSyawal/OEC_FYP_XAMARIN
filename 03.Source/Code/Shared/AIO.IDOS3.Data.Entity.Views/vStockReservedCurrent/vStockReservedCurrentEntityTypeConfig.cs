﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:33
// Description   : vStockReservedCurrentEntityTypeConfig class.
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

    public class vStockReservedCurrentEntityTypeConfig : IEntityTypeConfiguration<vStockReservedCurrent>, IEdmEntityConfiguration<vStockReservedCurrent>
    {

        #region Implements IEntityTypeConfiguration<vStockReservedCurrent>
        
        public void Configure(EntityTypeBuilder<vStockReservedCurrent> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReservedCurrent>

        public string EntitySetName { get; } = "vStockReservedCurrents";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReservedCurrent> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReservedCurrent
        {
            builder.ToTable("vStockReservedCurrent");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.WarehouseID, p.ProductID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReservedCurrent
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.WarehouseID, p.ProductID });
        }

        #endregion

    }

}