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
        private readonly ICloudinaryService cloudinaryService;

        public AdminServices(IApplicationDbRepository _repo, ICloudinaryService _cloudinaryService)
        {
            repo = _repo;
            cloudinaryService = _cloudinaryService;
        }

        public void AddClothes([FromForm]ClothesViewModel model)
        {        
            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");



            repo.AddAsync(new Cloth()
            {
                Category = model.Category,
                Color = model.Color,
                Description = model.Description,
                Material = model.Material,
                Name = model.Name,
                Price = model.Price,
                Size = model.Size,
                ImageUrl = imageUrl
            });

            repo.SaveChanges();
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
