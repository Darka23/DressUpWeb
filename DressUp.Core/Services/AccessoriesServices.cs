using DressUp.Core.Contracts;
using DressUp.Core.Models.DetailsViewModels;
using DressUp.Core.Models.ListViewModels;
using DressUp.Infrastructure.Data.Models;
using DressUp.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Services
{
    public class AccessoriesServices : IAccessoriesServices
    {
        private readonly IApplicationDbRepository repo;

        public AccessoriesServices(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<AccessoriesListViewModel> GetAllAccessories()
        {
            return repo.All<Accessory>()
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public IEnumerable<AccessoriesListViewModel> GetAllBracelets()
        {
            return repo.All<Accessory>()
                .Where(a => a.AccessoryType == "Гривна")
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public IEnumerable<AccessoriesListViewModel> GetAllEarrings()
        {
            return repo.All<Accessory>()
                .Where(a => a.AccessoryType == "Обеци")
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public IEnumerable<AccessoriesListViewModel> GetAllKeychains()
        {
            return repo.All<Accessory>()
                .Where(a=> a.AccessoryType == "Ключодържател")
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public IEnumerable<AccessoriesListViewModel> GetAllNecklaces()
        {
            return repo.All<Accessory>()
                .Where(a => a.AccessoryType == "Колие")
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public IEnumerable<AccessoriesListViewModel> GetAllRings()
        {
            return repo.All<Accessory>()
                .Where(a => a.AccessoryType == "Пръстен")
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public IEnumerable<AccessoriesListViewModel> GetAllWatches()
        {
            return repo.All<Accessory>()
                .Where(a => a.AccessoryType == "Часовник")
                .Select(a => new AccessoriesListViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price
                });
        }

        public AccessoriesDetailsViewModel? GetAccessoryById(int id)
        {
            return repo.All<Accessory>()
                .Where(a => a.Id == id)
                .Select(a => new AccessoriesDetailsViewModel()
                {
                    Name = a.Name,
                    Id = a.Id,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    Price = a.Price,                
                })
                .FirstOrDefault();
        }
    }
}
