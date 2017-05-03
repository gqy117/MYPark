using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYPark.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MYPark.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserCarparkRepository UserCarparkRepository = new UserCarparkRepository();

        public IActionResult Index()
        {
            HomeModel homeModel = new HomeModel();
            IList<UserCarpark> userCarparkList = this.UserCarparkRepository.GetAll();

            homeModel.UserCarparks = userCarparkList;

            return View(homeModel);
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
