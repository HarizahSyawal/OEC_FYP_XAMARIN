using System.Linq;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Effects
{

    public class TintImageEffect : RoutingEffect
    {

        #region Static Members

        public static readonly BindableProperty TintColorProperty = BindableProperty.CreateAttached( "TintImageEffect", typeof(Color), typeof(TintImageEffect), default(Color),
            propertyChanged: OnTintColorChanged);

        #endregion

        #region Constructors

        public TintImageEffect()
            : base(string.Format("CustomEffects.{0}", nameof(TintImageEffect)))
        {

        }

        #endregion

        #region Properties

        public Color TintColor { get; }

        #endregion

        #region Methods
        
        public static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
                return;

            if (!view.Effects.Any(e => e is TintImageEffect))
                view.Effects.Add(new TintImageEffect());
        }

        public static Color GetTintColor(BindableObject bindable)
        {
            return (Color)bindable.GetValue(TintColorProperty);
        }

        public static void SetTintColor(BindableObject bindable, Color value)
        {
            bindable.SetValue(TintColorProperty, value);
        }

        #endregion

    }

}
