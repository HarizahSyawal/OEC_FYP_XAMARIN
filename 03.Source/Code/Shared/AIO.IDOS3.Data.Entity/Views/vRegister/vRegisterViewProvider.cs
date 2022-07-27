using System;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vRegisterViewProvider : DataViewProvider<vRegister>
    {

        #region Methods

        protected override void OnInsertData(vRegister obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vRegister obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vRegister obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vRegister obj, bool useTransaction)
        {
            var registerTableProvider = DbContext.GetDataTableProvider<RegisterTableProvider>();

            var register = new Register();

            register.Username = obj.Username;
            register.Email = obj.Email;
            register.Password = obj.Password;


            await registerTableProvider.InsertDataAsync(register);
            obj.ID = register.ID;
        }

        protected override async Task OnUpdateDataAsync(vRegister obj, bool useTransaction)
        {
            var registerTableProvider = DbContext.GetDataTableProvider<RegisterTableProvider>();

            var register = new Register();

            register.Username = obj.Username;
            register.Email = obj.Email;
            register.Password = obj.Password;


            await registerTableProvider.UpdateDataAsync(register);
        }

        protected override async Task OnDeleteDataAsync(vRegister obj, bool useTransaction)
        {
            if (ValidateDelete(obj))
            {
                var registerTableProvider = DbContext.GetDataTableProvider<RegisterTableProvider>();

                var register = await registerTableProvider.GetDataAsync(obj.ID);

                //register.IsDeleted = true;

                await registerTableProvider.DeleteDataAsync(register);
            }
        }



        private bool ValidateDelete(vRegister obj)
        {
            // Check dependency to other tables here

            return true;
        }

        #endregion

    }
}
