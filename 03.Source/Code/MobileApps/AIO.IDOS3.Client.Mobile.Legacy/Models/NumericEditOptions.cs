namespace AIO.IDOS3.Client.Mobile.Models
{

    public class NumericEditOptions<T> : EditBaseOptions<T>
    {

        #region Properties

        private bool isReadOnly = false;
        public bool IsReadOnly { get { return isReadOnly; } set { SetProperty(ref isReadOnly, value); } }

        private bool allowNullValue = false;
        public bool AllowNullValue { get { return allowNullValue; } set { SetProperty(ref allowNullValue, value); } }

        #endregion

    }

}
