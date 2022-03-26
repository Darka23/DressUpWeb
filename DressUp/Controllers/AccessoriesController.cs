using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class AccessoriesController : BaseController
    {
        private readonly IAccessoriesServices accessoriesServices;

        public AccessoriesController(IAccessoriesServices _accessoriesServices)
        {
            accessoriesServices = _accessoriesServices;
        }

        public IActionResult Accessories()
        {
            var accessories = accessoriesServices.GetAllAccessories();

            var model = new
            {
                Accessories = accessories
            };

            return View(model);
        }

        public IActionResult Watches()
        {
            var watches = accessoriesServices.GetAllWatches();

            var model = new
            {
                Watches = watches
            };

            return View(model);
        }

        public IActionResult Necklaces()
        {
            var necklaces = accessoriesServices.GetAllNecklaces();

            var model = new
            {
                Necklaces = necklaces
            };

            return View(model);
        }

        public IActionResult Bracelets()
        {
            var bracelets = accessoriesServices.GetAllBracelets();

            var model = new
            {
                Bracelets = bracelets
            };

            return View(model);
        }

        public IActionResult Keychains()
        {
            var keychains = accessoriesServices.GetAllKeychains();

            var model = new
            {
                Keychains = keychains
            };

            return View(model);
        }

        public IActionResult Rings()
        {
            var rings = accessoriesServices.GetAllRings();

            var model = new
            {
                Rings = rings
            };

            return View(model);
        }

        public IActionResult Earrings()
        {
            var earrings = accessoriesServices.GetAllEarrings();

            var model = new
            {
                Earrings = earrings
            };

            return View(model);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
