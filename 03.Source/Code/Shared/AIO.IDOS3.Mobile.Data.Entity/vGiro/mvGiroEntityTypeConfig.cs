﻿// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:02
// Description   : mvGiroEntityTypeConfig class.
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

    public class mvGiroEntityTypeConfig : IEntityTypeConfiguration<mvGiro>, IEdmEntityConfiguration<mvGiro>
    {

        #region Fields

        private vGiroEntityTypeConfig parentConfig = new vGiroEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvGiro>

        public void Configure(EntityTypeBuilder<mvGiro> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvGiro>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvGiro> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}