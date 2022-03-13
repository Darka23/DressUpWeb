using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class BagsController : Controller
    {
        public IActionResult Bags()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
