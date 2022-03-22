using DressUp.Core.Models;

namespace DressUp.Core.Contracts
{
    public interface IAdminServices
    {
        void AddColor(ColorViewModel model);

        void AddMaterial(MaterialViewModel model);
    }
}
