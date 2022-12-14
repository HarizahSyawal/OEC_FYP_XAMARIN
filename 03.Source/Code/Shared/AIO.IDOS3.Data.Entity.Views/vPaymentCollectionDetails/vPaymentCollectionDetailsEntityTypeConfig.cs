// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:06
// Description   : vPaymentCollectionDetailsEntityTypeConfig class.
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

    public class vPaymentCollectionDetailsEntityTypeConfig : IEntityTypeConfiguration<vPaymentCollectionDetails>, IEdmEntityConfiguration<vPaymentCollectionDetails>
    {

        #region Implements IEntityTypeConfiguration<vPaymentCollectionDetails>

        public void Configure(EntityTypeBuilder<vPaymentCollectionDetails> builder)
        {
            InternalConfigure(builder);

            builder.HasOne(p => p.Parent)
                .WithMany(q => q.ChildDetails)
                .HasForeignKey(p => new { p.DocumentID })
                .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<vPaymentCollectionDetails>

        public string EntitySetName { get; } = "vPaymentCollectionDetails";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vPaymentCollectionDetails> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vPaymentCollectionDetails
        {
            builder.ToTable("vPaymentCollectionDetails");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.InvoiceDocumentID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vPaymentCollectionDetails
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID, p.InvoiceDocumentID });
        }

        #endregion

    }

}
