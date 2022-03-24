using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class BagsController : BaseController
    {
        private readonly IBagsServices bagsServices;

        public BagsController(IBagsServices _bagsServices)
        {
            bagsServices = _bagsServices;
        }
        public IActionResult Bags()
        {
            var bags = bagsServices.GetBags();

            var model = new
            {
                Bags = bags
            };

            return View(model);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
