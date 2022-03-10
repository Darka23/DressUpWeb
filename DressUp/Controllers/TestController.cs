using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
