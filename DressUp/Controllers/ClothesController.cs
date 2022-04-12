using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DressUp.Controllers
{
    public class ClothesController : BaseController
    {
        private readonly IClothesServices clothesServices;
        private Random rnd = new Random();

        public ClothesController(IClothesServices _clothesServices)
        {
            clothesServices = _clothesServices;
        }

        public IActionResult ClothesMen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfClothes = clothesServices.GetMenClothes()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfClothes);
        }

        public IActionResult ClothesWomen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfClothes = clothesServices.GetWomenClothes()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber,pageSize);

            return View(onePageOfClothes);
        }
        public IActionResult ClothesChildren(int? page)
        {
            
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfClothes = clothesServices.GetChildrenClothes()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfClothes);
        }

        public IActionResult ClothesAll(int? page)
        {
            var rnd = new Random();
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfClothes = clothesServices.GetAllClothes()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfClothes);
        }      

        public IActionResult Details(int id)
        {
            var model = clothesServices.GetClothesById(id);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            clothesServices.DeleteClothes(id);

            return Redirect("/");
        }
    }
}
