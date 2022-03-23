using DressUp.Core.Models;
using DressUp.Infrastructure.Data.Models;

namespace DressUp.Core.Contracts
{
    public interface IAdminServices
    {
        void AddColor(ColorViewModel model);
        void AddMaterial(MaterialViewModel model);
        void AddClothes(ClothesViewModel model);

        IEnumerable<Color> GetColors();
        IEnumerable<Material> GetMaterials();

    }
}
