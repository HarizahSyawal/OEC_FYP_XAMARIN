using AIO.IDOS3.Mobile.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class CustomerCallCheckOutNoSalesReasonModel : BindableErrorBase
    {

        #region Constructors

        public CustomerCallCheckOutNoSalesReasonModel()
        {
            NoSalesReasonOptions.IsRequired = true;
            NoSalesReasonOptions.Caption = "Reason";
        }

        #endregion

        #region Properties

        private ComboBoxEditOptions<mvSystemLookup> noSalesReasonOptions = new ComboBoxEditOptions<mvSystemLookup>();
        public ComboBoxEditOptions<mvSystemLookup> NoSalesReasonOptions { get { return noSalesReasonOptions; } set { SetProperty(ref noSalesReasonOptions, value); } }
        private int? noSalesReasonID = null;
        public int? NoSalesReasonID { get { return noSalesReasonID; } set { SetProperty(ref noSalesReasonID, value); } }

        private string noSalesReasonPhotoEvidence = null;
        public string NoSalesReasonPhotoEvidence { get { return noSalesReasonPhotoEvidence; } set { SetProperty(ref noSalesReasonPhotoEvidence, value); } }
        private ImageSource noSalesReasonPhotoEvidenceImage = null;
        public ImageSource NoSalesReasonPhotoEvidenceImage { get { return noSalesReasonPhotoEvidenceImage; } set { SetProperty(ref noSalesReasonPhotoEvidenceImage, value); } }

        #endregion

        #region Methods

        public void Reset()
        {
            noSalesReasonID = null;            
            noSalesReasonPhotoEvidence = null;
            noSalesReasonPhotoEvidenceImage = null;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (isValid && (NoSalesReasonID != null));

            return isValid;
        }

        #endregion

    }

}
