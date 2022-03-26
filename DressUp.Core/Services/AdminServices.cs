using DressUp.Core.Contracts;
using DressUp.Core.Models;
using DressUp.Core.Models.AddViewModels;
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

        public void AddAccessories([FromForm]AccessoriesViewModel model)
        {
            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");

            repo.AddAsync(new Accessory()
            {
                ImageUrl = imageUrl,
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
            });

            repo.SaveChanges();
        }

        public void AddBags([FromForm] BagsViewModel model)
        {
            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");

            repo.AddAsync(new Bag()
            {
                ImageUrl = imageUrl,
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                Color = model.Color,
                Material = model.Material,
                Category = model.Category,
                Condition = model.Condition,
            });

            repo.SaveChanges();

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
                ImageUrl = imageUrl,
                Condition = model.Condition,
            });

            repo.SaveChanges();
        }
        public void AddShoes([FromForm] ShoesViewModel model)
        {
            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");

            repo.AddAsync(new Shoe()
            {
                ImageUrl = imageUrl,
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                Size = model.Size,
                Category = model.Category,
                Condition = model.Condition,
            });

            repo.SaveChanges();
        }

        public void AddColor([FromForm] ColorViewModel model)
        {
            repo.AddAsync(new Color
            {
                ColorName = model.ColorName,
            });

            repo.SaveChanges();
        }

        public void AddMaterial([FromForm] MaterialViewModel model)
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
