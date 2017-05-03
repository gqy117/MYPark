using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYPark.Service
{
    public class HomeService
    {
        private readonly CarparkService CarparkService;

        public HomeService(CarparkService carparkService)
        {
            this.CarparkService = carparkService;
        }

        public HomeModel Index()
        {
            HomeModel homeModel = new HomeModel();
            homeModel.UserCarparks = this.CarparkService.GetAll();

            return homeModel;
        }
    }
}
