using DressUp.Core.Models;
using DressUp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Core.Contracts
{
    public interface IAdminServices
    {
        void AddColor([FromForm] ColorViewModel model);
        void AddMaterial([FromForm] MaterialViewModel model);
        void AddClothes([FromForm] ClothesViewModel model);
        void AddAccessories([FromForm] AccessoriesViewModel model);
        void AddShoes([FromForm] ShoesViewModel model);
        void AddBags([FromForm] BagsViewModel model);


        IEnumerable<Color> GetColors();
        IEnumerable<Material> GetMaterials();

    }
}
