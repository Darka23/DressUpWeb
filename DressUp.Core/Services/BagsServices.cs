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
    }
}
