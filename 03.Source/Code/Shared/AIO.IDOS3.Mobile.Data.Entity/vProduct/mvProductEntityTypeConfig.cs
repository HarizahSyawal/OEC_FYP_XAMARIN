﻿// ===================================================================================
// Author        : System
// Created date  : 30 Aug 2020 07:11:04
// Description   : mvProductEntityTypeConfig class.
//
// Modified by   :
// Modified date :
// Comments      :
//
// NOTE: This file is initially generated by system and can be modified following
//       the requirement.
// ===================================================================================

using AIO.IDOS3.Data.Entity;
using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
{

    public class mvProductEntityTypeConfig : IEntityTypeConfiguration<mvProduct>, IEdmEntityConfiguration<mvProduct>
    {

        #region Fields

        private vProductEntityTypeConfig parentConfig = new vProductEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvProduct>

        public void Configure(EntityTypeBuilder<mvProduct> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvProduct>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvProduct> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}