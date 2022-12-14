// ===================================================================================
// Author        : System
// Created date  : 06 Aug 2020 17:31:06
// Description   : CountryEntityTypeConfig class.
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

    public class CountryEntityTypeConfig : IEntityTypeConfiguration<Country>
    {

        #region Implements IEntityTypeConfiguration<Country>
        
        public void Configure(EntityTypeBuilder<Country> builder) { InternalConfigure(builder); }

        public void InternalConfigure<TData>(EntityTypeBuilder<TData> builder) where TData : Country
        {
            builder.ToTable("Country");

            // Define at least one key for Entity here. Example: builder.HasKey(p => new { p.ID });
            builder.HasKey(p => new { p.ID });
        }
        
        #endregion

    }

}
