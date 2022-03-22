using DressUp.Core.Contracts;
using DressUp.Core.Models;
using DressUp.Infrastructure.Data.Models;
using DressUp.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Core.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IApplicationDbRepository repo;

        public AdminServices(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public void AddColor(ColorViewModel model)
        {            
            repo.AddAsync(new Color
            {
                ColorName = model.ColorName,
            });

            repo.SaveChanges();
        }

        public void AddMaterial(MaterialViewModel model)
        {
            

            repo.AddAsync(new Material
            {
                MaterialName = model.MaterialName,
            });

            repo.SaveChanges();
        }

        public IEnumerable<Color> GetColors()
        {
            return repo.All<Color>().ToList();
        }

        public IEnumerable<Material> GetMaterials()
        {
            return repo.All<Material>().ToList();
        }
    }
}
