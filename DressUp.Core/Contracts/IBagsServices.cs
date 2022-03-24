using DressUp.Core.Models.ListViewModels;
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
    }
}
