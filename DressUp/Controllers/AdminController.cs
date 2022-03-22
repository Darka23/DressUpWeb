using DressUp.Core.Contracts;
using DressUp.Core.Models;
using DressUp.Infrastructure.Data.Common;
using DressUp.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DressUp.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAdminServices adminServices;
        public AdminController(IAdminServices _adminServices)
        {
            adminServices = _adminServices;
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

            return Redirect("/");
        }

        public IActionResult AddMaterial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMaterial(MaterialViewModel model)
        {
            adminServices.AddMaterial(model);

            return Redirect("/");
        }

        public IActionResult AddClothes()
        {
            return View();
        }
        public IActionResult AddBags()
        {
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
