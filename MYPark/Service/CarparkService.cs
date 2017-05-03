using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MYPark.Repository;

namespace MYPark.Service
{
    public class CarparkService
    {
        private readonly UserCarparkRepository UserCarparkRepository;

        public CarparkService(UserCarparkRepository userCarparkRepository)
        {
            this.UserCarparkRepository = userCarparkRepository;
        }

        public IList<UserCarpark> GetAll()
        {
            IList<UserCarpark> userCarparkList = this.UserCarparkRepository.GetAll();

            return userCarparkList;
        }

        public void Park(UserCarpark userCarpark)
        {
            List<UserCarpark> userCarparkList = this.UserCarparkRepository.GetAll();

            var indexRecord = userCarparkList.FindIndex(x => x.CarparkID == userCarpark.CarparkID);

            userCarparkList[indexRecord] = userCarpark;

            this.UserCarparkRepository.UpdateAll(userCarparkList);
        }
    }
}
