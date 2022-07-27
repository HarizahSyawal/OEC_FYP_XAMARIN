using System;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vAnnouncementViewProvider : DataViewProvider<vAnnouncement>
    {
        #region Methods

        protected override void OnInsertData(vAnnouncement obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vAnnouncement obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vAnnouncement obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vAnnouncement obj, bool useTransaction)
        {
            var announcementTableProvider = DbContext.GetDataTableProvider<AnnouncementTableProvider>();

            var announcement = new Announcement();

            announcement.Title = obj.Title;
            announcement.Photo = obj.Photo;
            announcement.Description = obj.Description;


            await announcementTableProvider.InsertDataAsync(announcement);
            obj.ID = announcement.ID;
        }

        protected override async Task OnUpdateDataAsync(vAnnouncement obj, bool useTransaction)
        {
            var announcementTableProvider = DbContext.GetDataTableProvider<AnnouncementTableProvider>();

            var announcement = new Announcement();

            announcement.Title = obj.Title;
            announcement.Photo = obj.Photo;
            announcement.Description = obj.Description;


            await announcementTableProvider.UpdateDataAsync(announcement);
        }

        protected override async Task OnDeleteDataAsync(vAnnouncement obj, bool useTransaction)
        {
            if (ValidateDelete(obj))
            {
                var announcementTableProvider = DbContext.GetDataTableProvider<AnnouncementTableProvider>();

                var announcement = await announcementTableProvider.GetDataAsync(obj.ID);

                //register.IsDeleted = true;

                await announcementTableProvider.DeleteDataAsync(announcement);
            }
        }



        private bool ValidateDelete(vAnnouncement obj)
        {
            // Check dependency to other tables here

            return true;
        }

        #endregion
    }
}
