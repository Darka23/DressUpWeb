using DressUp.Core.Contracts;
using DressUp.Core.Models.CartModels;
using DressUp.Infrastructure.Data.Models;
using DressUp.Infrastructure.Data.Repositories;

namespace DressUp.Core.Services
{
    public class CartServices : ICartServices
    {
        private readonly IApplicationDbRepository repo;

        public CartServices(IApplicationDbRepository _repo)
        {
            repo = _repo;
        }
        
        public Cloth? AddClothToCart(int id)
        {
            return repo.All<Cloth>()
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
        public Bag? AddBagToCart(int id)
        {
            return repo.All<Bag>()
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
        public Accessory? AddAccessoryToCart(int id)
        {
            return repo.All<Accessory>()
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
        public Shoe? AddShoesToCart(int id)
        {
            return repo.All<Shoe>()
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }
    }
}
