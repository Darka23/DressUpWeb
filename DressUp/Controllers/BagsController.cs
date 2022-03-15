using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class BagsController : BaseController
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
