using Wismapi.Data.SQLiteNet;

namespace AIO.IDOS3.Mobile.Data.SQLiteNet
{
    public class mvRegisterEntityTypeConfig : IEdmEntityConfiguration<mvRegister>
    {
        #region Implements IEdmEntityConfiguration<mvUser>

        public string EntitySetName { get; } = "vRegisters";

        #endregion
    }
}