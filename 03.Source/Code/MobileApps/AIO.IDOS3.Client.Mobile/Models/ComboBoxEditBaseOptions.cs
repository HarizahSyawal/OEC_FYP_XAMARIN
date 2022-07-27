using System.Collections.Generic;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class ComboBoxEditOptions<T> : EditBaseOptions<T>
    {

        #region Properties

        private List<T> items = new List<T>();
        public List<T> Items { get { return items; } set { SetProperty(ref items, value); } }

        #endregion

    }

}
