using DressUp.Core.Models;
using DressUp.Core.Models.AddViewModels;
using DressUp.Core.Models.EditViewModels;
using DressUp.Core.Models.ListViewModels;
using DressUp.Infrastructure.Data.Identity;
using DressUp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Core.Contracts
{
    public interface IAdminServices
    {
        Task AddColor([FromForm] ColorViewModel model);
        Task AddMaterial([FromForm] MaterialViewModel model);
        Task AddClothes([FromForm] ClothesViewModel model);
        Task AddAccessories([FromForm] AccessoriesViewModel model);
        Task AddShoes([FromForm] ShoesViewModel model);
        Task AddBags([FromForm] BagsViewModel model);
        Task<bool> EditClothes([FromForm] ClothesEditViewModel model);
        Task<bool> EditShoes([FromForm] ShoesEditViewModel model);
        Task<bool> EditAccessories([FromForm] AccessoriesEditViewModel model);
        Task<bool> EditBags([FromForm] BagsEditViewModel model);
        List<UsersListViewModel> UsersList();
        void DeleteUser(string id);

        IEnumerable<Color> GetColors();
        IEnumerable<Material> GetMaterials();

    }
}
