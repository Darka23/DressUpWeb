using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DressUp.Controllers
{
    public class ShoesController : BaseController
    {
        private readonly IShoesServices shoesServices;

        public ShoesController(IShoesServices _shoesServices)
        {
            shoesServices = _shoesServices;
        }
        public IActionResult Shoes(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetAllShoes()
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult ShoesMen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetShoesMen()
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult ShoesWomen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetShoesWomen()
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult ShoesChildren(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfShoes = shoesServices.GetShoesChildren()
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfShoes);
        }
        public IActionResult Details(int id)
        {
            var model = shoesServices.GetShoesById(id);
            return View(model);
        }
    }
}
