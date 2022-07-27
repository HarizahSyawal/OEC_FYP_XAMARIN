using Microsoft.OData.Client;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Csdl;
using Microsoft.OData.Edm.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Wismapi.Data.SQLiteNet
{

    public static class EdmModelBuilder
    {

        #region Methods

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

        #endregion

    }

}
