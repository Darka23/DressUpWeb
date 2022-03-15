using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult AdminPanel()
        {
            return View();
        }
        public IActionResult AddColor()
        {
            return View();
        }


        public IActionResult AddMaterial()
        {
            return View();
        }
        public IActionResult AddClothes()
        {
            return View();
        }
        public IActionResult AddBags()
        {
            return View();
        }
        public IActionResult AddAccessories()
        {
            return View();
        }
        public IActionResult AddShoes()
        {
            return View();
        }
    }
}
