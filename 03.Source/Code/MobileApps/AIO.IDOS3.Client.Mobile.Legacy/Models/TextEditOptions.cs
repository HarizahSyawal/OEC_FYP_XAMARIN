﻿namespace AIO.IDOS3.Client.Mobile.Models
{

    public class TextEditOptions<T> : EditBaseOptions<T>
    {

        #region Properties

        private bool isReadOnly = false;
        public bool IsReadOnly { get { return isReadOnly; } set { SetProperty(ref isReadOnly, value); } }

        #endregion

    }

}
