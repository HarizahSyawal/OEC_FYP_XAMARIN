﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:35
// Description   : vStockReturnForDisposalDetailsEntityTypeConfig class.
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

    public class vStockReturnForDisposalDetailsEntityTypeConfig : IEntityTypeConfiguration<vStockReturnForDisposalDetails>, IEdmEntityConfiguration<vStockReturnForDisposalDetails>
    {

        #region Implements IEntityTypeConfiguration<vStockReturnForDisposalDetails>
        
        public void Configure(EntityTypeBuilder<vStockReturnForDisposalDetails> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vStockReturnForDisposalDetails>

        public string EntitySetName { get; } = "vStockReturnForDisposalDetails";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vStockReturnForDisposalDetails> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vStockReturnForDisposalDetails
        {
            builder.ToTable("vStockReturnForDisposalDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vStockReturnForDisposalDetails
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.ProductID, p.ProductLotID });
        }

        #endregion

    }

}