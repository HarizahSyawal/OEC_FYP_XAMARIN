using System;

namespace Wismapi.Data.SQLiteNet
{

    public static class SQLiteNetExt
    {

        #region Classes

        [AttributeUsage(AttributeTargets.Property)]
        public class PrimaryKeyAttribute : Attribute
        {

            #region Constructors

            public PrimaryKeyAttribute()
            {

            }
            
            #endregion

        }

        [AttributeUsage(AttributeTargets.Property)]
        public class IgnoreAttribute : Attribute
        {

            #region Constructors

            public IgnoreAttribute()
            {

            }

            #endregion

        }

        #endregion

    }

}
