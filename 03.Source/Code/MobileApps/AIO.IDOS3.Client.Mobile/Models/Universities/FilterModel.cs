using AIO.IDOS3.Client.Mobile.ViewModels;
using System.Collections.Generic;

namespace AIO.IDOS3.Client.Mobile.Models
{
    public class FilterModel
    {
        public List<FilterViewModel> Get()
        {
            List<FilterViewModel> list = new List<FilterViewModel>();
            list.Add(new FilterViewModel { Name = "Location" });
            list.Add(new FilterViewModel { Name = "Instant Approval" });
            list.Add(new FilterViewModel { Name = "Accreditation" });
            return list;
        }

    }
}
