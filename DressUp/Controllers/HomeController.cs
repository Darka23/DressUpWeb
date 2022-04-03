using DressUp.Core.Models.CartModels;
using DressUp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DressUp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (this.HttpContext.Session.Get("Cart") == null)
            {
                this.HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(new Cart()));
            }

            this.ViewData["Cart"] = this.HttpContext.Session.GetString("Cart") == null
            ? null
            : JsonConvert.DeserializeObject(this.HttpContext.Session.GetString("Cart"));

            var a = JsonConvert.DeserializeObject(this.HttpContext.Session.GetString("Cart"));
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SizeTable()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}