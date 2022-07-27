using System;
using System.Threading.Tasks;
using Wismapi.Data.Entity;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vUniversityViewProvider : DataViewProvider<vUniversity>
    {

        #region Methods

        protected override void OnInsertData(vUniversity obj, bool useTransaction) { OnInsertDataAsync(obj, useTransaction).Wait(); }
        protected override void OnUpdateData(vUniversity obj, bool useTransaction) { OnUpdateDataAsync(obj, useTransaction).Wait(); }
        protected override void OnDeleteData(vUniversity obj, bool useTransaction) { OnDeleteDataAsync(obj, useTransaction).Wait(); }


        protected override async Task OnInsertDataAsync(vUniversity obj, bool useTransaction)
        {
            var universityTableProvider = DbContext.GetDataTableProvider<UniversityTableProvider>();

            var university = new University();

            university.UnivName = obj.UnivName;
            university.UnivPhoto = obj.UnivPhoto;
            university.UnivAddress = obj.UnivAddress;
            university.UnivDetails = obj.UnivDetails;

            await universityTableProvider.InsertDataAsync(university);
            obj.ID = university.ID;
        }

        protected override async Task OnUpdateDataAsync(vUniversity obj, bool useTransaction)
        {
            var universityTableProvider = DbContext.GetDataTableProvider<UniversityTableProvider>();

            var university = await universityTableProvider.GetDataAsync(obj.ID);

            university.UnivName = obj.UnivName;
            university.UnivPhoto = obj.UnivPhoto;
            university.UnivAddress = obj.UnivAddress;
            university.UnivDetails = obj.UnivDetails;

            await universityTableProvider.UpdateDataAsync(university);
        }

        protected override async Task OnDeleteDataAsync(vUniversity obj, bool useTransaction)
        {
            if (ValidateDelete(obj))
            {
                var universityTableProvider = DbContext.GetDataTableProvider<UniversityTableProvider>();

                var university = await universityTableProvider.GetDataAsync(obj.ID);

               // user.IsDeleted = true;

                await universityTableProvider.UpdateDataAsync(university);
            }
        }



        private bool ValidateDelete(vUniversity obj)
        {
            // Check dependency to other tables here

            return true;
        }

        #endregion

    }
}
