using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class ShoesController : BaseController
    {
        private readonly IShoesServices shoesServices;

        public ShoesController(IShoesServices _shoesServices)
        {
            shoesServices = _shoesServices;
        }
        public IActionResult Shoes()
        {
            var shoes = shoesServices.GetAllShoes();

            var model = new
            {
                Shoes = shoes
            };

            return View(model);
        }
        public IActionResult ShoesMen()
        {
            var shoes = shoesServices.GetShoesMen();

            var model = new
            {
                Shoes = shoes
            };

            return View(model);
        }
        public IActionResult ShoesWomen()
        {
            var shoes = shoesServices.GetShoesWomen();

            var model = new
            {
                Shoes = shoes
            };

            return View(model);
        }
        public IActionResult ShoesChildren()
        {
            var shoes = shoesServices.GetShoesChildren();

            var model = new
            {
                Shoes = shoes
            };

            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = shoesServices.GetShoesById(id);
            return View(model);
        }
    }
}
