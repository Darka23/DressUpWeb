using DressUp.Core.Models.DetailsViewModels;
using DressUp.Core.Models.ListViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Contracts
{
    public interface IAccessoriesServices
    {
        IEnumerable<AccessoriesListViewModel> GetAllAccessories();
        IEnumerable<AccessoriesListViewModel> GetAllWatches();
        IEnumerable<AccessoriesListViewModel> GetAllNecklaces();
        IEnumerable<AccessoriesListViewModel> GetAllBracelets();
        IEnumerable<AccessoriesListViewModel> GetAllKeychains();
        IEnumerable<AccessoriesListViewModel> GetAllRings();
        IEnumerable<AccessoriesListViewModel> GetAllEarrings();
        AccessoriesDetailsViewModel GetAccessoryById(int id);

        void DeleteAccessory(int id);
    }
}
