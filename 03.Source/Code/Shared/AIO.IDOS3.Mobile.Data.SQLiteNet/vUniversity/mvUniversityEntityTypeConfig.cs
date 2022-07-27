using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public class mvUniversityEntityTypeConfig : IEdmEntityConfiguration<mvUniversity>
    {
        #region Implements IEdmEntityConfiguration<mvUniversity>

        public string EntitySetName { get; } = "vUniversitys";

        #endregion
    }
}
