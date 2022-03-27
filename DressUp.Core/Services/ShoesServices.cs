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
    public class ShoesServices : IShoesServices
    {
        private readonly IApplicationDbRepository repo;

        public ShoesServices(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }

        public IEnumerable<ShoesListViewModel> GetAllShoes()
        {
            return repo.All<Shoe>()
                .Select(s => new ShoesListViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImageUrl = s.ImageUrl,
                    Price = s.Price
                });
        }


        public IEnumerable<ShoesListViewModel> GetShoesChildren()
        {
            return repo.All<Shoe>()
                .Where(s => s.Category == "Деца")
                .Select(s => new ShoesListViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImageUrl = s.ImageUrl,
                    Price = s.Price
                });
        }

        public IEnumerable<ShoesListViewModel> GetShoesMen()
        {
            return repo.All<Shoe>()
                .Where(s => s.Category == "Мъже")
                .Select(s => new ShoesListViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImageUrl = s.ImageUrl,
                    Price = s.Price
                });
        }

        public IEnumerable<ShoesListViewModel> GetShoesWomen()
        {
            return repo.All<Shoe>()
                .Where(s => s.Category == "Жени")
                .Select(s => new ShoesListViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImageUrl = s.ImageUrl,
                    Price = s.Price
                });
        }

        public ShoesDetailsViewModel? GetShoesById(int id)
        {
            return repo.All<Shoe>()
                .Where(s => s.Id == id)
                .Select(s => new ShoesDetailsViewModel()
                {
                    Name = s.Name,
                    Id = s.Id,
                    Category = s.Category,
                    Condition = s.Condition,
                    Description = s.Description,
                    ImageUrl = s.ImageUrl,
                    Price = s.Price,
                    Size = s.Size,                   
                })
                .FirstOrDefault();
        }
    }
}
