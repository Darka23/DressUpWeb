using DressUp.Core.Contracts;
using DressUp.Core.Models;
using DressUp.Infrastructure.Data.Common;
using DressUp.Infrastructure.Data.Models;
using DressUp.Infrastructure.Data.Repositories;
using DressUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DressUp.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAdminServices adminServices;
        private readonly IApplicationDbRepository repo;

        public AdminController(IAdminServices _adminServices, IApplicationDbRepository _repo)
        {
            adminServices = _adminServices;
            repo = _repo;
        }

        public IActionResult AdminPanel()
        {
            return View();
        }
        public IActionResult AddColor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddColor(ColorViewModel model)
        {           
            adminServices.AddColor(model);

            return Redirect("/Admin/AdminPanel");
        }

        public IActionResult AddMaterial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMaterial(MaterialViewModel model)
        {
            adminServices.AddMaterial(model);

            return Redirect("/Admin/AdminPanel");
        }

        public IActionResult AddClothes()
        {
            var colors = adminServices.GetColors();
            var materials = adminServices.GetMaterials();

            ViewBag.clothesColors = colors.Select(c => new SelectListItem() { Value = c.ColorName, Text = c.ColorName });
            ViewBag.clothesMaterials = materials.Select(m => new SelectListItem() { Value = m.MaterialName, Text = m.MaterialName });

            return View();
        }

        [HttpPost]
        public IActionResult AddClothes(ClothesViewModel model)
        {
            adminServices.AddClothes(model);

            return Redirect("/Admin/AdminPanel");
        }

        public IActionResult AddBags()
        {
            var colors = adminServices.GetColors();
            var materials = adminServices.GetMaterials();

            ViewBag.bagsColors = colors.Select(c => new SelectListItem() { Value = c.ColorName, Text = c.ColorName });
            ViewBag.bagsMaterials = materials.Select(m => new SelectListItem() { Value = m.MaterialName, Text = m.MaterialName });

            return View();
        }

        [HttpPost]
        public IActionResult AddBags(BagsViewModel model)
        {
            adminServices.AddBags(model);

            return Redirect("/Admin/AdminPanel");
        }


        public IActionResult AddAccessories()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAccessories(AccessoriesViewModel model)
        {
            adminServices.AddAccessories(model);

            return Redirect("/Admin/AdminPanel");
        }


        public IActionResult AddShoes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddShoes(ShoesViewModel model)
        {
            adminServices.AddShoes(model);

            return Redirect("/Admin/AdminPanel");
        }
    }
}
