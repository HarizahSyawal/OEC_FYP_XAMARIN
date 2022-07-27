using Prism.Mvvm;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class BindableErrorBase : BindableBase
    {

        #region Properties

        private bool isError = false;
        public bool IsError { get { return isError; } set { SetProperty(ref isError, value); } }

        private string errorMessage = "";
        public string ErrorMessage { get { return errorMessage; } set { SetProperty(ref errorMessage, value); } }

        #endregion

        #region Methods

        public void ResetErrorMessage()
        {
            IsError = false;
            ErrorMessage = "";
        }

        public void SetErrorMessage(string message)
        {
            IsError = true;
            ErrorMessage = message;
        }

        #endregion

    }

}
