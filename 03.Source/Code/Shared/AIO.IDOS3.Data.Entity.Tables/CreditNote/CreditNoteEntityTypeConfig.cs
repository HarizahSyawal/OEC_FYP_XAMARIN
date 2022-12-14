// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:06
// Description   : CreditNoteEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AIO.IDOS3.Data.Entity
{

    public class CreditNoteEntityTypeConfig : IEntityTypeConfiguration<CreditNote>
    {

        #region Implements IEntityTypeConfiguration<CreditNote>
        
        public void Configure(EntityTypeBuilder<CreditNote> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : CreditNote
        {
            builder.ToTable("CreditNote");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.DocumentID });
        }
        
        #endregion

    }

}
