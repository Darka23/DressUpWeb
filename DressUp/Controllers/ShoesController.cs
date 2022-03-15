using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class ShoesController : BaseController
    {
        public IActionResult Shoes()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
