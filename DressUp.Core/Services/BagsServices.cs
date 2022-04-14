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
    public class BagsServices : IBagsServices
    {
        private readonly IApplicationDbRepository repo;

        public BagsServices(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }
        public IEnumerable<BagsListViewModel> GetBags()
        {
            return repo.All<Bag>()
                .Select(b => new BagsListViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    ImageUrl = b.ImageUrl,
                    Price = b.Price
                });
        }


        public IEnumerable<BagsListViewModel> GetBagsChildren()
        {
            return repo.All<Bag>()
                .Where(b=>b.Category == "Деца")
                .Select(b => new BagsListViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    ImageUrl = b.ImageUrl,
                    Price = b.Price
                });
        }

        public IEnumerable<BagsListViewModel> GetBagsMen()
        {
            return repo.All<Bag>()
                .Where(b => b.Category == "Мъже")
                .Select(b => new BagsListViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    ImageUrl = b.ImageUrl,
                    Price = b.Price
                });
        }

        public IEnumerable<BagsListViewModel> GetBagsWomen()
        {
            return repo.All<Bag>()
                .Where(b => b.Category == "Жени")
                .Select(b => new BagsListViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    ImageUrl = b.ImageUrl,
                    Price = b.Price
                });
        }

        public BagsDetailsViewModel? GetBagsById(int id)
        {
            return repo.All<Bag>()
                .Where(b=> b.Id == id)
                .Select(b => new BagsDetailsViewModel()
                {
                   Name = b.Name,
                   Id = b.Id,
                   Category = b.Category,
                   Color = b.Color,
                   Condition = b.Condition,
                   Description = b.Description,
                   ImageUrl = b.ImageUrl,
                   Material = b.Material,
                   Price = b.Price
                })
                .FirstOrDefault();
        }

        public void DeleteBag(int id)
        {
            var bag = repo.All<Bag>()
                .Where(x => x.Id == id)
                .First();

            repo.Delete(bag);

            repo.SaveChanges();
        }
    }
}
