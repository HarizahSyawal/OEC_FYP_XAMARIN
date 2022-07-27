﻿// ===================================================================================
// Author        : System
// Created date  : 08 Oct 2020 05:23:01
// Description   : mvFinanceInstitutionEntityTypeConfig class.
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

    public class mvFinanceInstitutionEntityTypeConfig : IEntityTypeConfiguration<mvFinanceInstitution>, IEdmEntityConfiguration<mvFinanceInstitution>
    {

        #region Fields

        private vFinanceInstitutionEntityTypeConfig parentConfig = new vFinanceInstitutionEntityTypeConfig();

        #endregion

        #region Implements IEntityTypeConfiguration<mvFinanceInstitution>

        public void Configure(EntityTypeBuilder<mvFinanceInstitution> builder) { parentConfig.InternalConfigure(builder); }

        #endregion

        #region Implements IEdmEntityConfiguration<mvFinanceInstitution>

        public string EntitySetName { get { return parentConfig.EntitySetName; } }

        public void ConfigureEdmEntity(EntityTypeConfiguration<mvFinanceInstitution> builder) { parentConfig.InternalConfigureEdmEntity(builder); }

        #endregion

    }

}