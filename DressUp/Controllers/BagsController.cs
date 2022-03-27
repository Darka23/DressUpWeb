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

        public IActionResult BagsMen()
        {
            var bags = bagsServices.GetBagsMen();

            var model = new
            {
                Bags = bags
            };

            return View(model);
        }

        public IActionResult BagsWomen()
        {
            var bags = bagsServices.GetBagsWomen();

            var model = new
            {
                Bags = bags
            };

            return View(model);
        }

        public IActionResult BagsChildren()
        {
            var bags = bagsServices.GetBagsChildren();

            var model = new
            {
                Bags = bags
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = bagsServices.GetBagsById(id);
            return View(model);
        }
    }
}
