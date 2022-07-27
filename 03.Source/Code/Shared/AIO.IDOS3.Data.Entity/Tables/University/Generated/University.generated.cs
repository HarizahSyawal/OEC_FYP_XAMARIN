using System;
namespace AIO.IDOS3.Data.Entity
{
    public partial class University : IUniversity
    {

        #region Implements IUniversity

        public int ID { get; set; }
        public string UnivName { get; set; }
        public string UnivPhoto { get; set; }
        public string UnivAddress { get; set; }
        public string UnivDetails { get; set; }



        public void CopyFrom(IUniversity obj)
        {
            ID = obj.ID;
            UnivName = obj.UnivName;
            UnivPhoto = obj.UnivPhoto;
            UnivAddress = obj.UnivAddress;
            UnivDetails = obj.UnivDetails;
        }

        #endregion

    }
}
