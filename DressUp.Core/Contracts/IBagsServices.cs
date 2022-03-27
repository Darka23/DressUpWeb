using DressUp.Core.Models.DetailsViewModels;
using DressUp.Core.Models.ListViewModels;
using DressUp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Contracts
{
    public interface IBagsServices
    {
        IEnumerable<BagsListViewModel> GetBags();
        IEnumerable<BagsListViewModel> GetBagsWomen();
        IEnumerable<BagsListViewModel> GetBagsMen();
        IEnumerable<BagsListViewModel> GetBagsChildren();
        BagsDetailsViewModel GetBagsById(int id); 
    }
}
