using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class ClothesController : Controller
    {
        public IActionResult ClothesMen()
        {
            return View();
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
