using AIO.IDOS3.Mobile.Data.Entity;
using System;
using System.ComponentModel;

namespace AIO.IDOS3.Client.Mobile.Models
{

    public class SelectPrinterModel : BindableErrorBase
    {

        #region Constructors

        public SelectPrinterModel()
        {

        }

        #endregion

        #region Properties

        

        #endregion

        #region Methods

        public void Reset()
        {

            ResetErrorMessage();
        }

        public bool Validate()
        {
            ResetErrorMessage();

            bool isValid = true;
                        
            return isValid;
        }

        #endregion

    }

}
