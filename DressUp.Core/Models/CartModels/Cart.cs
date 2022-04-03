using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressUp.Core.Models.CartModels
{
    public class Cart
    {
        public Cart()
        {
            this.CartProducts = new List<CartProduct>();
        }
        public List<CartProduct> CartProducts { get; set; }
    }
}
