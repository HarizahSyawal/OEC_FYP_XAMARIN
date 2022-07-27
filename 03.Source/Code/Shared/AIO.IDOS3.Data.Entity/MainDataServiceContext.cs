using Microsoft.OData.Edm;
using System;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{

    public class MainDataServiceContext : CoreDataServiceContext
    {

        #region Static Members

        protected static readonly string MainCsdlFileName = "MainDataServiceContextCsdl.xml";

        #endregion

        #region Constructors

        public MainDataServiceContext()
            : this(DataServiceRoot)
        {
            
        }

        public MainDataServiceContext(Uri serviceRoot)
            : this(serviceRoot, null, DataServiceUseEdmModelCsdl)
        {

        }

        public MainDataServiceContext(Uri serviceRoot, MainDbContext dbContext)
            : this(serviceRoot, dbContext, DataServiceUseEdmModelCsdl)
        {

        }

        public MainDataServiceContext(Uri serviceRoot, MainDbContext dbContext, bool useEdmModelCsdl)
            : this(serviceRoot, dbContext, ((useEdmModelCsdl) ? EdmModelBuilder.GetEdmModelFromCsdlResource<MainDataServiceContext>(MainCsdlFileName) : MainDbContext.EdmModel))
        {

        }

        public MainDataServiceContext(Uri serviceRoot, MainDbContext dbContext, IEdmModel edmModel)
            : base(serviceRoot, dbContext)
        {
            Format.LoadServiceModel = () =>
            {
                EdmModel = (edmModel != null) ? edmModel : MainDbContext.EdmModel;

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
