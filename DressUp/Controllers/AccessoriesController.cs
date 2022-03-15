using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class AccessoriesController : BaseController
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
