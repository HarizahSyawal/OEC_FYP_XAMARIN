// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:46:10
// Description   : vRolePermissionEntityTypeConfig class.
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

    public class vRolePermissionEntityTypeConfig : IEntityTypeConfiguration<vRolePermission>, IEdmEntityConfiguration<vRolePermission>
    {

        #region Implements IEntityTypeConfiguration<vRolePermission>
        
        public void Configure(EntityTypeBuilder<vRolePermission> builder) { InternalConfigure(builder); }

        #endregion
        
        #region Implements IEdmEntityConfiguration<vRolePermission>

        public string EntitySetName { get; } = "vRolePermissions";

        public void ConfigureEdmEntity(EntityTypeConfiguration<vRolePermission> builder) { InternalConfigureEdmEntity(builder); }

        #endregion
        
        #region Methods

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : vRolePermission
        {
            builder.ToTable("vRolePermission");

            //// Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.RoleID, p.PermissionObjectID });
        }
        
        public void InternalConfigureEdmEntity<TData>(EntityTypeConfiguration<TData> builder) where TData : vRolePermission
        {
            // Define at least one key for EDM Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.RoleID, p.PermissionObjectID });
        }

        #endregion

    }

}
