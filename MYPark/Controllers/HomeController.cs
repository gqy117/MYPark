using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYPark.Repository;
using Microsoft.AspNetCore.Mvc;
using MYPark.Service;

namespace MYPark.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService HomeService;

        public HomeController(HomeService homeService)
        {
            this.HomeService = homeService;
        }

        public IActionResult Index()
        {
            return View(this.HomeService.Index());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
