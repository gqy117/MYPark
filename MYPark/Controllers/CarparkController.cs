using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYPark.Repository;
using Microsoft.AspNetCore.Mvc;
using MYPark.Service;

namespace MYPark.Controllers
{
    public class CarparkController : Controller
    {
        private readonly CarparkService CarparkService;

        public CarparkController(CarparkService carparkService)
        {
            this.CarparkService = carparkService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            IList<UserCarpark> userCarparkList = this.CarparkService.GetAll();

            return this.Json(userCarparkList);
        }

        [HttpPost]
        public IActionResult Park(UserCarpark userCarpark)
        {
            this.CarparkService.Park(userCarpark);

            return this.Json("Done");
        }
    }
}
