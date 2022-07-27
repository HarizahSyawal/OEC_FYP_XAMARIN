using AIO.IDOS3.Mobile.Data.Entity;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class SyncModel : BindableErrorBase
    {

        #region Properties

        public bool FirstSync { get; set; }
        public mvUser User { get; set; }

        #endregion

    }

}
