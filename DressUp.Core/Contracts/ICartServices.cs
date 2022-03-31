using DressUp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Contracts
{
    public interface ICartServices
    {
        Cloth? AddClothToCart(int id);
        Bag? AddBagToCart(int id);
        Accessory? AddAccessoryToCart(int id);
        Shoe? AddShoesToCart(int id);
    }
}
