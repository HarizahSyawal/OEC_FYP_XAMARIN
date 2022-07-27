using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vAnnouncement : BaseEntityType, IvAnnouncement
    {
        #region Implements IvAnnouncement

        public int ID { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        public void CopyFrom(IvAnnouncement obj)
        {
            ID = obj.ID;
            Title = obj.Title;
            Photo = obj.Photo;
            Description = obj.Description;

        }

        #endregion
    }
}
