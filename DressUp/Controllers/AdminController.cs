using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class AdminController : BaseController
    {
        public IActionResult AdminPanel()
        {
            return View();
        }
    }
}
