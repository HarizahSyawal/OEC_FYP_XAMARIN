using Microsoft.AspNet.OData.Builder;

namespace Wismapi.Data.Entity
{

    public interface IEdmEntityConfiguration<TEntity> where TEntity : class
    {

        #region Properties

        string EntitySetName { get; }

        #endregion

        #region Methods

        void ConfigureEdmEntity(EntityTypeConfiguration<TEntity> builder);

        #endregion

    }

}
