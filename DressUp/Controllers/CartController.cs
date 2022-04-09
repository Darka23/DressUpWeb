using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using DressUp.Core.Models.CartModels;
using DressUp.Infrastructure.Data.Repositories;
using DressUp.Infrastructure.Data.Models;
using DressUp.Core.Constants;

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

        //Clothes
        [HttpGet]
        public JsonResult GetCartItemForCloth(int id)
        {
            var clothing = cartServices.AddClothToCart(id);           

            return Json(clothing);
        }

        [HttpPost]
        public IActionResult AddClothToCart(int id)
        {
            var clothing = cartServices.AddClothToCart(id);

            return RedirectToAction("Cart");
        }

        //Bags
        [HttpGet]
        public JsonResult GetCartItemForBag(int id)
        {
            var bag = cartServices.AddBagToCart(id);

            return Json(bag);
        }

        [HttpPost]
        public IActionResult AddBagToCart(int id)
        {
            var bag = cartServices.AddBagToCart(id);

            return RedirectToAction("Cart");
        }

        //Accessories
        [HttpGet]
        public JsonResult GetCartItemForAccessory(int id)
        {
            var accessory = cartServices.AddAccessoryToCart(id);

            return Json(accessory);
        }

        [HttpPost]
        public IActionResult AddAccessoryToCart(int id)
        {
            var accessory = cartServices.AddAccessoryToCart(id);

            return RedirectToAction("Cart");
        }

        //Shoes
        [HttpGet]
        public JsonResult GetCartItemForShoe(int id)
        {
            var shoes = cartServices.AddShoesToCart(id);

            return Json(shoes);
        }

        [HttpPost]
        public IActionResult AddShoesToCart(int id)
        {
            var shoes = cartServices.AddShoesToCart(id);

            return RedirectToAction("Cart");
        }
    }
}
