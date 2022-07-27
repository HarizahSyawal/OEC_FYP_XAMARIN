using System;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vLoginViewProvider : DataViewProvider<vLogin>
    {

        #region Methods

        protected override void OnInsertData(vLogin obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vLogin obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vLogin obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vLogin obj, bool useTransaction)
        {
            var loginTableProvider = DbContext.GetDataTableProvider<LoginTableProvider>();

            var login = new Login();

            login.ID = obj.ID;
            login.Username = obj.Username;
            login.Password = obj.Password;
            

            await loginTableProvider.InsertDataAsync(login);
            obj.ID = login.ID;
        }

        protected override async Task OnUpdateDataAsync(vLogin obj, bool useTransaction)
        {
            var loginTableProvider = DbContext.GetDataTableProvider<LoginTableProvider>();

            var login = new Login();

            login.ID = obj.ID;
            login.Username = obj.Username;
            login.Password = obj.Password;


            await loginTableProvider.UpdateDataAsync(login);
        }

        protected override async Task OnDeleteDataAsync(vLogin obj, bool useTransaction)
        {
            if (ValidateDelete(obj))
            {
                var loginTableProvider = DbContext.GetDataTableProvider<LoginTableProvider>();

                var login = await loginTableProvider.GetDataAsync(obj.ID);

                //register.IsDeleted = true;

                await loginTableProvider.DeleteDataAsync(login);
            }
        }



        private bool ValidateDelete(vLogin obj)
        {
            // Check dependency to other tables here

            return true;
        }

        #endregion

    }
}
