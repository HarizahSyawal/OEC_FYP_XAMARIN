using System;
namespace AIO.IDOS3.Data
{
    public partial interface IUniversity
    {
        #region Properties

        int ID { get; set; }
        string UnivName { get; set; }
        string UnivPhoto { get; set; }
        string UnivAddress { get; set; }
        string UnivDetails { get; set; }

        #endregion

        #region Methods

        void CopyFrom(IUniversity obj);

        #endregion
    }
}
