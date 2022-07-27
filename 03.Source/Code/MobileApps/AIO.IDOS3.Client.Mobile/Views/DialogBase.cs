using AIO.IDOS3.Client.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class DialogBase<TViewModel> : Frame where TViewModel: IDialogViewModel
    {

        #region Constructors

        public DialogBase()
        {
            
        }

        #endregion

        #region Properties

        public TViewModel ViewModel { get { return (TViewModel)BindingContext; } }

        #endregion

    }

}
