using Microsoft.OData.Edm;
using System;
using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{

    public class MobileDataServiceContext : CoreDataServiceContext
    {

        #region Static Members

        protected static readonly string MobileCsdlFileName = "MobileDataServiceContextCsdl.xml";
        
        #endregion

        #region Constructors

        public MobileDataServiceContext()
            : this(DataServiceRoot)
        {

        }

        public MobileDataServiceContext(Uri serviceRoot)
            : this(serviceRoot, null)
        {

        }

        public MobileDataServiceContext(Uri serviceRoot, MobileDbContext dbContext)
            : base(serviceRoot, dbContext)
        {
            Format.LoadServiceModel = () =>
            {
                if (EdmModel == null)
                    EdmModel = EdmModelBuilder.GetEdmModelFromCsdlResource<MobileDataServiceContext>(MobileCsdlFileName);

                return EdmModel;
            };

            Format.UseJson();
            Timeout = 300; // Timeout
        }

        #endregion

        #region Properties

        public static Uri DataServiceRoot { get; set; } = null;

        #endregion

    }

}
