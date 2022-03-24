using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class ClothesController : BaseController
    {
        private readonly IClothesServices clothesServices;

        public ClothesController(IClothesServices _clothesServices)
        {
            clothesServices = _clothesServices;
        }

        public IActionResult ClothesMen()
        {
            var clothes = clothesServices.GetMenClothes();

            var model = new
            {
                Clothes = clothes
            };

            return View(model);
        }

        public IActionResult ClothesWomen()
        {
            return View();
        }
        public IActionResult ClothesChildren()
        {
            return View();
        }        
        public IActionResult Details()
        {
            return View();
        }
    }
}
