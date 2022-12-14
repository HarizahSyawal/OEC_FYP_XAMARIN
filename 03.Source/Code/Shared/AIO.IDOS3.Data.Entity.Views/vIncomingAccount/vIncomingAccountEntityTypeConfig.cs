// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:01
// Description   : vIncomingAccountEntityTypeConfig class.
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

    public class vIncomingAccountEntityTypeConfig : IEntityTypeConfiguration<vIncomingAccount>, IEdmEntityConfiguration<vIncomingAccount>
    {

        #region Implements IEntityTypeConfiguration<vIncomingAccount>
        
        public void Configure(EntityTypeBuilder<vIncomingAccount> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vIncomingAccount>

        public string EntitySetName { get; } = "vIncomingAccounts";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vIncomingAccount> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vIncomingAccount
        {
            builder.ToTable("vIncomingAccount");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vIncomingAccount
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }

        #endregion

    }

}
