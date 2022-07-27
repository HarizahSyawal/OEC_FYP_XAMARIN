using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class GirosModel : BindableErrorBase
    {

        #region Properties

        private ObservableCollection<mvGiro> giros = new ObservableCollection<mvGiro>();
        public ObservableCollection<mvGiro> Giros { get { return giros; } set { SetProperty(ref giros, value); } }

        #endregion

    }

}
