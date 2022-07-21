using DressUp.Core.Constants;
using DressUp.Core.Contracts;
using DressUp.Core.Models.AddViewModels;
using DressUp.Core.Models.EditViewModels;
using DressUp.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DressUp.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IAdminServices adminServices;

        public AdminController(IAdminServices _adminServices, IApplicationDbRepository _repo)
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddColor(ColorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddColor", "Admin");
            }

            await adminServices.AddColor(model);

            return Redirect("/Admin/Admin/AdminPanel");
        }

        public IActionResult AddMaterial()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMaterial(MaterialViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddMaterial", "Admin");
            }

            await adminServices.AddMaterial(model);

            return Redirect("/Admin/Admin/AdminPanel");
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClothes(ClothesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddClothes", "Admin");
            }

            await adminServices.AddClothes(model);

            return Redirect("/Admin/Admin/AdminPanel");
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBags(BagsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddBags", "Admin");
            }

            await adminServices.AddBags(model);

            return Redirect("/Admin/Admin/AdminPanel");
        }


        public IActionResult AddAccessories()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAccessories(AccessoriesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddAccessory", "Admin");
            }

            await adminServices.AddAccessories(model);

            return Redirect("/Admin/Admin/AdminPanel");
        }


        public IActionResult AddShoes()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddShoes(ShoesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddShoes", "Admin");
            }
            await adminServices.AddShoes(model);

            return Redirect("/Admin/Admin/AdminPanel");
        }


        public IActionResult EditClothes(int id)
        {
            var colors = adminServices.GetColors();
            var materials = adminServices.GetMaterials();

            ViewBag.clothesColors = colors.Select(c => new SelectListItem() { Value = c.ColorName, Text = c.ColorName });
            ViewBag.clothesMaterials = materials.Select(m => new SelectListItem() { Value = m.MaterialName, Text = m.MaterialName });

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> EditClothes(ClothesEditViewModel model)
        {

            if (await adminServices.EditClothes(model))
            {
                ViewData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                ViewData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return Redirect("/Home/Index");
        }

        public IActionResult EditShoes(int id)
        {          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditShoes(ShoesEditViewModel model)
        {

            if (await adminServices.EditShoes(model))
            {
                ViewData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                ViewData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return Redirect("/Home/Index");
        }

        public IActionResult EditAccessories(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditAccessories(AccessoriesEditViewModel model)
        {

            if (await adminServices.EditAccessories(model))
            {
                ViewData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                ViewData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return Redirect("/Home/Index");
        }

        public IActionResult EditBags(int id)
        {
            var colors = adminServices.GetColors();
            var materials = adminServices.GetMaterials();

            ViewBag.bagsColors = colors.Select(c => new SelectListItem() { Value = c.ColorName, Text = c.ColorName });
            ViewBag.bagsMaterials = materials.Select(m => new SelectListItem() { Value = m.MaterialName, Text = m.MaterialName });

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditBags(BagsEditViewModel model)
        {

            if (await adminServices.EditBags(model))
            {
                ViewData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                ViewData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return Redirect("/Home/Index");
        }

        public IActionResult UserList()
        {
            var users = adminServices.UsersList();

            var model = new
            {
                Users = users
            };

            return View(model);
        }

        public IActionResult DeleteUser(string id)
        {
            adminServices.DeleteUser(id);
            return Redirect("/Admin/Admin/UserList");
        }
    }
}
