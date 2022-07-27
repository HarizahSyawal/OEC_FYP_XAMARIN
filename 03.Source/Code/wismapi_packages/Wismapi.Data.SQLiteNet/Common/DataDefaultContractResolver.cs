using Microsoft.OData.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace Wismapi.Data.Entity.Common
{

    public class DataDefaultContractResolver : DefaultContractResolver
    {

        #region Properties

        public static DataDefaultContractResolver Instance { get; } = new DataDefaultContractResolver();

        #endregion

        #region Methods

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            
            property.Ignored = (member.GetCustomAttribute(typeof(IgnoreClientPropertyAttribute)) != null);
            
            if (!property.Ignored)
            {
                if (property.PropertyType.Equals(typeof(DateTime)) || property.PropertyType.Equals(typeof(DateTime?)))
                {
                    ////////////////////////////////////////////////////
                }
            }

            return property;
        }
                
        #endregion

    }

}
