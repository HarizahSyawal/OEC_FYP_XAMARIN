using Microsoft.OData.Edm;
using System;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Mobile.Data.Entity
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
            : this(serviceRoot, null, DataServiceUseEdmModelCsdl)
        {

        }

        public MobileDataServiceContext(Uri serviceRoot, MobileDbContext dbContext)
            : this(serviceRoot, dbContext, DataServiceUseEdmModelCsdl)
        {

        }

        public MobileDataServiceContext(Uri serviceRoot, MobileDbContext dbContext, bool useEdmModelCsdl)
            : this(serviceRoot, dbContext, ((useEdmModelCsdl) ? EdmModelBuilder.GetEdmModelFromCsdlResource<MobileDataServiceContext>(MobileCsdlFileName) : MobileDbContext.EdmModel))
        {

        }

        public MobileDataServiceContext(Uri serviceRoot, MobileDbContext dbContext, IEdmModel edmModel)
            : base(serviceRoot, dbContext)
        {
            Format.LoadServiceModel = () =>
            {
                EdmModel = (edmModel != null) ? edmModel : MobileDbContext.EdmModel;

                return EdmModel;
            };

            Format.UseJson();
            Timeout = 300; // Timeout
        }

        #endregion

        #region Properties

        public static Uri DataServiceRoot { get; set; } = null;
        public static bool DataServiceUseEdmModelCsdl { get; set; } = false;

        #endregion

    }

}
