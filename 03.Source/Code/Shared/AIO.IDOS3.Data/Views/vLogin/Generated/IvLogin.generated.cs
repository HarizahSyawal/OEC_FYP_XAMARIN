namespace AIO.IDOS3.Data
{
    public partial interface IvLogin
    {
        #region Properties

        int ID { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        #endregion

        #region Methods

        void CopyFrom(IvLogin obj);

        #endregion
    }
}
