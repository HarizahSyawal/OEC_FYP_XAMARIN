using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.OData.Client;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Csdl;
using Microsoft.OData.Edm.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace Wismapi.Data.Entity
{

    public static class EdmModelBuilder
    {

        #region Methods

        public static IEdmModel GetConventionEdmModel(IEnumerable<IEntityType> entities)
        {
            return GetConventionEdmModelBuilder(entities).GetEdmModel();
        }

        public static ODataConventionModelBuilder GetConventionEdmModelBuilder(IEnumerable<IEntityType> entities)
        {
            var builder = new ODataConventionModelBuilder();
            var builderType = typeof(ODataConventionModelBuilder);
            Type[] typeArray = (entities.Count() == 0) ? new Type[] { } :
                entities.First().ClrType.Assembly.GetExportedTypes().Where(p => p.Name.EndsWith("EntityTypeConfig") && (p.GetInterface("IEdmEntityConfiguration`1") != null)).ToArray();

            foreach (var entityTypeConfig in typeArray)
            {
                var entityType = entityTypeConfig.GetInterface("IEdmEntityConfiguration`1").GenericTypeArguments[0];

                var paramBuilder = Expression.Parameter(builderType, "builder");
                var paramEntityTypeConfig = Expression.Parameter(typeof(Type), "entityTypeConfig");
                var callConfigureEdmEntity = Expression.Call(typeof(EdmModelBuilder), "ConfigureEdmEntity", new Type[] { entityType }, paramBuilder, paramEntityTypeConfig);
                Expression.Lambda<Action<ODataConventionModelBuilder, Type>>(callConfigureEdmEntity, paramBuilder, paramEntityTypeConfig).Compile()(builder, entityTypeConfig);
            }

            return builder;
        }

        public static IEdmModel GetEdmModelFromString(string edmxToParse)
        {
            return GetEdmModelFromXml(XmlReader.Create(new StringReader(edmxToParse)));
        }

        public static IEdmModel GetEdmModelFromCsdlResource<TServiceDataContext>(string csdlFileName) where TServiceDataContext : DataServiceContext
        {
            try
            {
                var assembly = typeof(TServiceDataContext).Assembly;
                var resourcePath = Enumerable.Single(assembly.GetManifestResourceNames(), str => str.EndsWith(csdlFileName));
                var stream = assembly.GetManifestResourceStream(resourcePath);

                return GetEdmModelFromXml(XmlReader.Create(new StreamReader(stream)));
            }
            catch (XmlException ex)
            {
                throw new XmlException("Failed to create an XmlReader from the stream. Check if the resource exists.", ex);
            }

        }

        public static IEdmModel GetEdmModelFromXml(XmlReader reader)
        {
            try
            {
                if (!CsdlReader.TryParse(reader, false, out IEdmModel edmModel, out IEnumerable<EdmError> errors))
                {
                    var errorMessages = new StringBuilder();
                    foreach (var error in errors)
                    {
                        errorMessages.Append(error.ErrorMessage);
                        errorMessages.Append("; ");
                    }

                    throw new InvalidOperationException(errorMessages.ToString());
                }

                return edmModel;
            }
            finally
            {
                ((IDisposable)(reader)).Dispose();
            }
        }



        public static void ConfigureEdmEntity<TEntity>(ODataConventionModelBuilder builder, Type entityTypeConfig) where TEntity : class
        {
            var entityType = typeof(TEntity);
            var entityTypeConfigInstance = (Expression.Lambda<Func<IEdmEntityConfiguration<TEntity>>>(Expression.New(entityTypeConfig.GetConstructor(Type.EmptyTypes))).Compile())();
            entityTypeConfigInstance.ConfigureEdmEntity(builder.EntityType<TEntity>());

            builder.EntitySet<TEntity>(entityTypeConfigInstance.EntitySetName);
        }

        #endregion

    }

}
