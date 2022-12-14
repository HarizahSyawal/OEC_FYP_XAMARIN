// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:39
// Description   : vUserPermissionEntityTypeConfig class.
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

    public class vUserPermissionEntityTypeConfig : IEntityTypeConfiguration<vUserPermission>, IEdmEntityConfiguration<vUserPermission>
    {

        #region Implements IEntityTypeConfiguration<vUserPermission>

        public void Configure(EntityTypeBuilder<vUserPermission> builder)
        {
            InternalConfigure(builder);

            builder.HasOne(p => p.ParentUser)
                .WithMany(q => q.ChildPermissions)
                .HasForeignKey(p => p.UserID);
        }

        #endregion

        #region Implements IEdmEntityConfiguration<vUserPermission>

        public string EntitySetName { get; } = "vUserPermissions";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vUserPermission> builder) { InternalConfigureEdmEntity(builder); }

        #endregion

        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vUserPermission
        {
            builder.ToTable("vUserPermission");

            //// Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.UserID, p.PermissionObjectID });
        }

        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vUserPermission
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.UserID, p.PermissionObjectID });
        }

        #endregion

    }

}
