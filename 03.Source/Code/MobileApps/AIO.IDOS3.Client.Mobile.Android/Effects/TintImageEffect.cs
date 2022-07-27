using AIO.IDOS3.Client.Mobile.Android.Effects;
using Android.Graphics;
using Android.Widget;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ResolutionGroupName("CustomEffects")]
[assembly: Xamarin.Forms.ExportEffect(typeof(TintImageEffect), nameof(TintImageEffect))]
namespace AIO.IDOS3.Client.Mobile.Android.Effects
{

    public class TintImageEffect : PlatformEffect
    {

        #region Fields

        private ImageView control;

        #endregion

        #region Methods

        protected override void OnAttached()
        {
            control = (ImageView)Control;
            UpdateTintColor();
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == AIO.IDOS3.Client.Mobile.Effects.TintImageEffect.TintColorProperty.PropertyName)
                UpdateTintColor();
        }

        private void UpdateTintColor()
        {
            try
            {
                var tintColor = AIO.IDOS3.Client.Mobile.Effects.TintImageEffect.GetTintColor(Element);
                var filter = new PorterDuffColorFilter(tintColor.ToAndroid(), PorterDuff.Mode.SrcIn);
                control.SetColorFilter(filter);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        protected override void OnDetached() { control = null; }

        #endregion

    }

}
