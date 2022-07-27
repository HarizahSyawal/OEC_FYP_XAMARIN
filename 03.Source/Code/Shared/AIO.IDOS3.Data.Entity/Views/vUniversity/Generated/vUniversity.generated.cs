using System;
using Microsoft.OData.Client;

namespace AIO.IDOS3.Data.Entity
{
    public partial class vUniversity : BaseEntityType, IvUniversity
    {
        #region Implements IvUniversity

        public int ID { get; set; }
        public string UnivName { get; set; }
        public string UnivPhoto { get; set; }
        public string UnivAddress { get; set; }
        public string UnivDetails { get; set; }

        #endregion

        #region Methods

        public void CopyFrom(IvUniversity obj)
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
