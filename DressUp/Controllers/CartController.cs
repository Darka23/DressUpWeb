using DressUp.Core.Contracts;
using DressUp.Infrastructure.Data.Models;
using DressUp.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class CartController : BaseController
    {
        private readonly ICartServices cartServices;

        public CartController(ICartServices _cartServices)
        {
            cartServices = _cartServices;         
        }
        public IActionResult Cart()
        {
            return View();          
        }

        [HttpPost]
        public IActionResult AddClothToCart(int id)
        {
            var clothing = cartServices.AddClothToCart(id);

            return RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult AddBagToCart(int id)
        {
            var bag = cartServices.AddBagToCart(id);

            return RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult AddAccessoryToCart(int id)
        {
            var accessory = cartServices.AddAccessoryToCart(id);

            return RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult AddShoesToCart(int id)
        {
            var shoes = cartServices.AddShoesToCart(id);

            return RedirectToAction("Cart");
        }
    }
}
