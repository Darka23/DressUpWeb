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
            var color = repo.All<Color>()
                .FirstOrDefault(c => c.ColorName == model.ColorName);

            if (color != null)
            {
                ViewBag.message = "Color already Exists!";
                return View("Error");
            }

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
            var color = repo.All<Material>()
                .FirstOrDefault(c => c.MaterialName == model.MaterialName);

            if (color != null)
            {
                ViewBag.message = "Material already Exists!";
                return View("Error");
            }

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
            return View();
        }

        public IActionResult AddBags()
        {
            var colors = adminServices.GetColors();
            var materials = adminServices.GetMaterials();

            ViewBag.bagsColors = colors.Select(c => new SelectListItem() { Value = c.ColorName, Text = c.ColorName });
            ViewBag.bagsMaterials = materials.Select(m => new SelectListItem() { Value = m.MaterialName, Text = m.MaterialName });

            return View();
        }
        public IActionResult AddAccessories()
        {
            return View();
        }
        public IActionResult AddShoes()
        {
            return View();
        }
    }
}
