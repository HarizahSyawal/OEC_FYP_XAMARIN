// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:01
// Description   : mvExchangeRateEntityTypeConfig class.
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
using AIO.IDOS3.Data.Entity;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public class mvExchangeRateEntityTypeConfig : IEntityTypeConfiguration<mvExchangeRate>, IEdmEntityConfiguration<mvExchangeRate>
    {

        #region Fields

        private vExchangeRateEntityTypeConfig parentConfig = new vExchangeRateEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvExchangeRate>

        public void Configure(EntityTypeBuilder<mvExchangeRate> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvExchangeRate>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvExchangeRate> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}
