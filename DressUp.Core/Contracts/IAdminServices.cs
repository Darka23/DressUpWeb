using DressUp.Core.Models;
using DressUp.Core.Models.AddViewModels;
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


        IEnumerable<Color> GetColors();
        IEnumerable<Material> GetMaterials();

    }
}
