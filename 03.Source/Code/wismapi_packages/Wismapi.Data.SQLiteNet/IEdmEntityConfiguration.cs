
namespace Wismapi.Data.SQLiteNet
{

    public interface IEdmEntityConfiguration<TEntity> where TEntity : class
    {

        #region Properties

        string EntitySetName { get; }

        #endregion

    }

}
