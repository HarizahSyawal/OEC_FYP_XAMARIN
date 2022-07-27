﻿// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:06
// Description   : vPaymentCollectionPopupDetailsEntityTypeConfig class.
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

    public class vPaymentCollectionPopupDetailsEntityTypeConfig : IEntityTypeConfiguration<vPaymentCollectionPopupDetails>, IEdmEntityConfiguration<vPaymentCollectionPopupDetails>
    {

        #region Implements IEntityTypeConfiguration<vPaymentCollectionPopupDetails>
        
        public void Configure(EntityTypeBuilder<vPaymentCollectionPopupDetails> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vPaymentCollectionPopupDetails>

        public string EntitySetName { get; } = "vPaymentCollectionPopupDetails";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vPaymentCollectionPopupDetails> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vPaymentCollectionPopupDetails
        {
            builder.ToTable("vPaymentCollectionPopupDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.InvoiceDocumentID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vPaymentCollectionPopupDetails
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.InvoiceDocumentID });
        }

        #endregion

    }

}
