using System;
using System.Collections.Generic;
using AIO.IDOS3.Client.Mobile.ViewModels;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{
    public partial class DetailsPage : PageBase<DetailsPageViewModel>
    {
        public DetailsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<Image> imageSources = new List<Image>()
            {
                new Image(){Title="Image 1",Url="utm1.jpeg"},
                new Image(){Title="Image 2",Url="utm4.jpeg"},
                new Image(){Title="Image 3",Url="utm6.jpeg"}

            };

            crsGallery.ItemsSource = imageSources;
        }
    }
}