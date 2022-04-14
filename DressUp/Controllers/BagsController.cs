using DressUp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DressUp.Controllers
{
    public class BagsController : BaseController
    {
        private readonly IBagsServices bagsServices;
        private Random rnd = new Random();

        public BagsController(IBagsServices _bagsServices)
        {
            bagsServices = _bagsServices;
        }
        public IActionResult Bags(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfBags = bagsServices.GetBags()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfBags);
        }

        public IActionResult BagsMen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfBags = bagsServices.GetBagsMen()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfBags);
        }

        public IActionResult BagsWomen(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfBags = bagsServices.GetBagsWomen()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfBags);
        }

        public IActionResult BagsChildren(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 12;
            var onePageOfBags = bagsServices.GetBagsChildren()
                .OrderBy(x => rnd.Next())
                .ToPagedList(pageNumber, pageSize);

            return View(onePageOfBags);
        }

        public IActionResult Details(int id)
        {
            var model = bagsServices.GetBagsById(id);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            bagsServices.DeleteBag(id);

            return Redirect("/");
        }
    }
}
