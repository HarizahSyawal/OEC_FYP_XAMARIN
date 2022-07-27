using Android.App;
using Android.Runtime;
using System;
using Xamarin.Essentials;

namespace AIO.IDOS3.Client.Mobile.Android
{

    public class MainApplication : Application
    {

        #region Constructors

        public MainApplication(IntPtr handle, JniHandleOwnership transfer)
            : base(handle, transfer)
        {

        }

        #endregion

        #region Methods

        public override void OnCreate()
        {
            base.OnCreate();

            Platform.Init(this);
        }

        #endregion

    }

}
