using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DressUp.Controllers
{
    public class ShoesController : BaseController
    {
        private readonly IShoesServices shoesServices;
        private Random rnd = new Random();

        public ShoesController(IShoesServices _shoesServices)
        {
            shoesServices = _shoesServices;
        }
        public IActionResult Shoes(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetAllShoes()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult ShoesMen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetShoesMen()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult ShoesWomen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetShoesWomen()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult ShoesChildren(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetShoesChildren()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult Details(int id)
        {
            var model = shoesServices.GetShoesById(id);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            shoesServices.DeleteShoes(id);

            return Redirect("/");
        }
    }
}
