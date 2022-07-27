using AIO.IDOS3.Mobile.Data.Entity;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class EditOtherActivitiesModel : BindableErrorBase
    {

        #region Constructors

        public EditOtherActivitiesModel()
        {
            MerchandiseDisplayActivityNoteOptions.IsRequired = true;
            MerchandiseDisplayActivityNoteOptions.Caption = "Note";

            PromotionalMaterialActivityNoteOptions.Caption = "Note";
        }

        #endregion

        #region Properties

        private TextEditOptions<string> merchandiseDisplayActivityNoteOptions = new TextEditOptions<string>();
        public TextEditOptions<string> MerchandiseDisplayActivityNoteOptions { get { return merchandiseDisplayActivityNoteOptions; } set { SetProperty(ref merchandiseDisplayActivityNoteOptions, value); } }
        private string merchandiseDisplayActivityNote = null;
        public string MerchandiseDisplayActivityNote { get { return merchandiseDisplayActivityNote; } set { SetProperty(ref merchandiseDisplayActivityNote, value); } }

        private string merchandiseDisplayActivityPhotoBefore = null;
        public string MerchandiseDisplayActivityPhotoBefore { get { return merchandiseDisplayActivityPhotoBefore; } set { SetProperty(ref merchandiseDisplayActivityPhotoBefore, value); } }
        private ImageSource merchandiseDisplayActivityPhotoBeforeImage = null;
        public ImageSource MerchandiseDisplayActivityPhotoBeforeImage { get { return merchandiseDisplayActivityPhotoBeforeImage; } set { SetProperty(ref merchandiseDisplayActivityPhotoBeforeImage, value); } }

        private string merchandiseDisplayActivityPhotoAfter = null;
        public string MerchandiseDisplayActivityPhotoAfter { get { return merchandiseDisplayActivityPhotoAfter; } set { SetProperty(ref merchandiseDisplayActivityPhotoAfter, value); } }
        private ImageSource merchandiseDisplayActivityPhotoAfterImage = null;
        public ImageSource MerchandiseDisplayActivityPhotoAfterImage { get { return merchandiseDisplayActivityPhotoAfterImage; } set { SetProperty(ref merchandiseDisplayActivityPhotoAfterImage, value); } }


        private TextEditOptions<string> promotionalMaterialActivityNoteOptions = new TextEditOptions<string>();
        public TextEditOptions<string> PromotionalMaterialActivityNoteOptions { get { return promotionalMaterialActivityNoteOptions; } set { SetProperty(ref promotionalMaterialActivityNoteOptions, value); } }
        private string promotionalMaterialActivityNote = null;
        public string PromotionalMaterialActivityNote { get { return promotionalMaterialActivityNote; } set { SetProperty(ref promotionalMaterialActivityNote, value); } }

        private string promotionalMaterialActivityPhotoBefore = null;
        public string PromotionalMaterialActivityPhotoBefore { get { return promotionalMaterialActivityPhotoBefore; } set { SetProperty(ref promotionalMaterialActivityPhotoBefore, value); } }
        private ImageSource promotionalMaterialActivityPhotoBeforeImage = null;
        public ImageSource PromotionalMaterialActivityPhotoBeforeImage { get { return promotionalMaterialActivityPhotoBeforeImage; } set { SetProperty(ref promotionalMaterialActivityPhotoBeforeImage, value); } }

        private string promotionalMaterialActivityPhotoAfter = null;
        public string PromotionalMaterialActivityPhotoAfter { get { return promotionalMaterialActivityPhotoAfter; } set { SetProperty(ref promotionalMaterialActivityPhotoAfter, value); } }
        private ImageSource promotionalMaterialActivityPhotoAfterImage = null;
        public ImageSource PromotionalMaterialActivityPhotoAfterImage { get { return promotionalMaterialActivityPhotoAfterImage; } set { SetProperty(ref promotionalMaterialActivityPhotoAfterImage, value); } }

        #endregion

        #region Methods

        public void Reset()
        {
            MerchandiseDisplayActivityNote = null;
            MerchandiseDisplayActivityPhotoBefore = null;
            MerchandiseDisplayActivityPhotoBeforeImage = null;
            MerchandiseDisplayActivityPhotoAfter = null;
            MerchandiseDisplayActivityPhotoAfterImage = null;

            PromotionalMaterialActivityNote = null;
            PromotionalMaterialActivityPhotoBefore = null;
            PromotionalMaterialActivityPhotoBeforeImage = null;
            PromotionalMaterialActivityPhotoAfter = null;
            PromotionalMaterialActivityPhotoAfterImage = null;

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;

            isValid = (MerchandiseDisplayActivityNoteOptions.Validate(MerchandiseDisplayActivityNote) && isValid);

            return isValid;
        }

        #endregion

    }

}
