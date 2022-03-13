using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class AccessoriesController : Controller
    {
        public IActionResult Accessories()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
