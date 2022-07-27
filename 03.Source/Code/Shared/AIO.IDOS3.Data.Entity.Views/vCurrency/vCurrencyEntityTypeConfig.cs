﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:54
// Description   : vCurrencyEntityTypeConfig class.
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

    public class vCurrencyEntityTypeConfig : IEntityTypeConfiguration<vCurrency>, IEdmEntityConfiguration<vCurrency>
    {

        #region Implements IEntityTypeConfiguration<vCurrency>
        
        public void Configure(EntityTypeBuilder<vCurrency> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vCurrency>

        public string EntitySetName { get; } = "vCurrencies";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vCurrency> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vCurrency
        {
            builder.ToTable("vCurrency");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vCurrency
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
