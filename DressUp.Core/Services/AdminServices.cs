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

        public async Task AddAccessories([FromForm]AccessoriesViewModel model)
        {
            var existing = repo.All<Accessory>()
                .Where(a => a.Name == model.Name)
                .FirstOrDefault();

            if (existing != null)
            {
                throw new ArgumentException("Accessory exist");
            }

            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");

            await repo.AddAsync(new Accessory()
            {
                ImageUrl = imageUrl,
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                AccessoryType = model.AccessoryType,
            });

            await repo.SaveChangesAsync();
        }

        public async Task AddBags([FromForm] BagsViewModel model)
        {
            var existing = repo.All<Bag>()
                .Where(b => b.Name == model.Name)
                .FirstOrDefault();

            if (existing != null)
            {
                throw new ArgumentException("Bag exist");
            }

            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");

            await repo.AddAsync(new Bag()
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

            await repo.SaveChangesAsync();

        }

        public async Task AddClothes([FromForm]ClothesViewModel model)
        {
            var existing = repo.All<Cloth>()
                .Where(c => c.Name == model.Name)
                .FirstOrDefault();

            if (existing != null)
            {
                throw new ArgumentException("Clothing piece exist");
            }

            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");           

            await repo.AddAsync(new Cloth()
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
                ClothingType = model.ClothingType,
            });

             await repo.SaveChangesAsync();
        }
        public async Task AddShoes([FromForm] ShoesViewModel model)
        {
            var existing = repo.All<Shoe>()
                .Where(s => s.Name == model.Name)
                .FirstOrDefault();

            if (existing != null)
            {
                throw new ArgumentException("Shoes exist");
            }

            string imageUrl = cloudinaryService.Image(model.Image, "DressUpImages");

            await repo.AddAsync(new Shoe()
            {
                ImageUrl = imageUrl,
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                Size = model.Size,
                Category = model.Category,
                Condition = model.Condition,
            });

            await repo.SaveChangesAsync();
        }

        public async Task AddColor([FromForm] ColorViewModel model)
        {
            await repo.AddAsync(new Color
            {
                ColorName = model.ColorName,
            });

            await repo.SaveChangesAsync();
        }

        public async Task AddMaterial([FromForm] MaterialViewModel model)
        {

            await repo.AddAsync(new Material
            {
                MaterialName = model.MaterialName,
            });

            await repo.SaveChangesAsync();
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
