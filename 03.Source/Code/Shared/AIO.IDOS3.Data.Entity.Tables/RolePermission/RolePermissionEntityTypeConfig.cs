// ===================================================================================
// Author        : System
// Created date  : 07 Aug 2020 02:45:11
// Description   : RolePermissionEntityTypeConfig class.
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

    public class RolePermissionEntityTypeConfig : IEntityTypeConfiguration<RolePermission>
    {

        #region Implements IEntityTypeConfiguration<RolePermission>
        
        public void Configure(EntityTypeBuilder<RolePermission> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : RolePermission
        {
            builder.ToTable("RolePermission");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.RoleID, p.PermissionObjectID });
        }
        
        #endregion

    }

}
