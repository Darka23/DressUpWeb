using DressUp.Core.Models.DetailsViewModels;
using DressUp.Core.Models.ListViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Contracts
{
    public interface IShoesServices
    {
        IEnumerable<ShoesListViewModel> GetAllShoes();
        IEnumerable<ShoesListViewModel> GetShoesMen();
        IEnumerable<ShoesListViewModel> GetShoesWomen();
        IEnumerable<ShoesListViewModel> GetShoesChildren();

        ShoesDetailsViewModel? GetShoesById(int id);

        void DeleteShoes(int id);
    }
}
