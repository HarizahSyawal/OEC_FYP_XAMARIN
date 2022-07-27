using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet.vLogin
{
    public class mvLoginEntityTypeConfig : IEdmEntityConfiguration<mvLogin>
    {
        #region Implements IEdmEntityConfiguration<mvLogin>

        public string EntitySetName { get; } = "vLogins";

        #endregion
    }
}
