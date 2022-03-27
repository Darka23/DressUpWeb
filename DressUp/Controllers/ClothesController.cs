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
            var clothes = clothesServices.GetWomenClothes();

            var model = new
            {
                Clothes = clothes
            };

            return View(model);
        }
        public IActionResult ClothesChildren()
        {
            var clothes = clothesServices.GetChildrenClothes();

            var model = new
            {
                Clothes = clothes
            };

            return View(model);
        }

        public IActionResult ClothesAll()
        {
            var clothes = clothesServices.GetAllClothes();

            var model = new
            {
                Clothes = clothes
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = clothesServices.GetClothesById(id);
            return View(model);
        }
    }
}
