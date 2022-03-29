using DressUp.Core.Models.DetailsViewModels;
using DressUp.Core.Models.ListViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Contracts
{
    public interface IClothesServices
    {
        IEnumerable<ClothesListViewModel> GetMenClothes();
        IEnumerable<ClothesListViewModel> GetWomenClothes();
        IEnumerable<ClothesListViewModel> GetChildrenClothes();
        IEnumerable<ClothesListViewModel> GetAllClothes();
        ClothesDetailsViewModel? GetClothesById(int id);
        void DeleteClothes(int id);


    }
}
