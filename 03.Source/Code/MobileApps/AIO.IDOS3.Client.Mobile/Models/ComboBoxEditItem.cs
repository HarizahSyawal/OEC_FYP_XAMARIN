namespace AIO.IDOS3.Client.Mobile.Models
{

    public class ComboBoxEditItem
    {

        #region Constructors

        public ComboBoxEditItem(int? id, string name)
        {
            ID = id;
            Name = name;
        }

        #endregion

        #region Properties

        public int? ID { get; set; }
        public string Name { get; set; }

        #endregion

    }

}
