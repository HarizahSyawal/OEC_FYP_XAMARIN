using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Wismapi.Data.Entity.Common
{

    #region DbCommandInt

    public class DbCommandObject { public object Result { get; set; } }

    public class DbCommandInt { public int Result { get; set; } }

    public class DbCommandIntEntityTypeConfig : IEntityTypeConfiguration<DbCommandInt>
    {
        public void Configure(EntityTypeBuilder<DbCommandInt> builder)
        {
            builder.HasAnnotation("QueryEntity", true);
            builder.HasNoKey();
        }
    }

    #endregion

    #region DbCommandDateTime

    public class DbCommandDateTime { public DateTime Result { get; set; } }

    public class DbCommandDateTimeEntityTypeConfig : IEntityTypeConfiguration<DbCommandDateTime>
    {
        public void Configure(EntityTypeBuilder<DbCommandDateTime> builder)
        {
            builder.HasAnnotation("QueryEntity", true);
            builder.HasNoKey();
        }
    }

    #endregion

}
