using DressUp.Core.Contracts;
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
    public class ClothesServices : IClothesServices
    {
        private readonly IApplicationDbRepository repo;

        public ClothesServices(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<ClothesListViewModel> GetMenClothes()
        {
            return repo.All<Cloth>()
                .Where(c => c.Category == "Мъже")
                .Select(c => new ClothesListViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Price = c.Price
                });
        }

        public IEnumerable<ClothesListViewModel> GetWomenClothes()
        {
            return repo.All<Cloth>()
                .Where(c => c.Category == "Жени")
                .Select(c => new ClothesListViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Price = c.Price
                });
        }
    }
}
