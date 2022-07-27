using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Views
{

    [DesignTimeVisible(false)]
    public partial class NavigationBarView : ContentView
    {

        #region Static Members

        //public static readonly BindableProperty BackButtonPressedCommandProperty = BindableProperty.Create(
        //    propertyName: "BackButtonPressedCommand",
        //    returnType: typeof(ICommand),
        //    declaringType: typeof(NavigationBarView),
        //    defaultValue: "",
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: (BindableObject bindable, object oldValue, object newValue) => { ((NavigationBarView)bindable).BackButtonPressedCommand = (ICommand)newValue; }
        //);

        //public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        //    propertyName: "Title",
        //    returnType: typeof(string),
        //    declaringType: typeof(NavigationBarView),
        //    defaultValue: "",
        //    defaultBindingMode: BindingMode.TwoWay,
        //    propertyChanged: (BindableObject bindable, object oldValue, object newValue) => { ((NavigationBarView)bindable).Title = (string)newValue; }
        //);

        #endregion

        #region Constructors

        public NavigationBarView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public ICommand BackButtonPressedCommand { get { return btnNavigateToBack.Command; } set { btnNavigateToBack.Command = value; } }
        public string Title { get { return lblTitle.Text; } set { lblTitle.Text = value; } }

        #endregion

    }

}
