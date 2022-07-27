﻿// ===================================================================================
// Author        : System
// Created date  : 19 Oct 2020 12:22:38
// Description   : mvCustomerCategoryEntityTypeConfig class.
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

    public class mvCustomerCategoryEntityTypeConfig : IEntityTypeConfiguration<mvCustomerCategory>, IEdmEntityConfiguration<mvCustomerCategory>
    {

        #region Fields

        private vCustomerCategoryEntityTypeConfig parentConfig = new vCustomerCategoryEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvCustomerCategory>

        public void Configure(EntityTypeBuilder<mvCustomerCategory> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvCustomerCategory>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvCustomerCategory> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}
