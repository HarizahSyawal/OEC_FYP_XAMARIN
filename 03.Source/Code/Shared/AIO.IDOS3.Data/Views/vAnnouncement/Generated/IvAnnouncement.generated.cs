namespace AIO.IDOS3.Data
{
    public partial interface IvAnnouncement
    {
        #region Properties

        int ID { get; set; }
        string Title { get; set; }
        string Photo { get; set; }
        string Description { get; set; }

        #endregion

        #region Methods
        void CopyFrom(IvAnnouncement obj);

        #endregion

    }
}
