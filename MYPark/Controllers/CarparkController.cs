using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYPark.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MYPark.Controllers
{
    public class CarparkController : Controller
    {
        private readonly UserCarparkRepository UserCarparkRepository = new UserCarparkRepository();

        public IActionResult Index()
        {
            IList<UserCarpark> userCarparkList = this.UserCarparkRepository.GetAll();

            return this.Json(userCarparkList);
        }

        public IActionResult Park(UserCarpark userCarpark)
        {
            List<UserCarpark> userCarparkList = this.UserCarparkRepository.GetAll();

            var indexRecord = userCarparkList.FindIndex(x => x.CarparkID == userCarpark.CarparkID);

            userCarparkList[indexRecord] = userCarpark;

            this.UserCarparkRepository.UpdateAll(userCarparkList);

            return this.Json("Done");
        }
    }
}
