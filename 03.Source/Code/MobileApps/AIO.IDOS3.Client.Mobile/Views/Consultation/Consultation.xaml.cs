using AIO.IDOS3.Client.Mobile.ViewModels;

using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views.Consultation
{
    public partial class Consultation : ContentPage
    {
        public Consultation()
        {
            this.BindingContext = new ConsultationViewModel();
            InitializeComponent();
        }
    }
}
