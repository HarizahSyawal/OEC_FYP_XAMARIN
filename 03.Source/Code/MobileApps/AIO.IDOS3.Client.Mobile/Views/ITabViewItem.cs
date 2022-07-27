using System.Threading.Tasks;

namespace AIO.IDOS3.Client.Mobile.Views
{

    public interface ITabViewItem
    {

        #region Methods

        Task OnSelectedChanged(bool selected);

        #endregion

    }

}
