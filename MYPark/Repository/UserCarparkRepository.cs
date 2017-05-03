using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MYPark.Repository
{
    public class UserCarparkRepository
    {
        public const string UserCarparkJson = @"DB/UserCarpark.json";

        public List<UserCarpark> GetAll()
        {
            List<UserCarpark> userCarparkList = new List<UserCarpark>();

            using (StreamReader file = File.OpenText(UserCarparkJson))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    userCarparkList = serializer.Deserialize<List<UserCarpark>>(reader);
                }
            }

            return userCarparkList;
        }

        public void UpdateAll(IList<UserCarpark> userCarparkList)
        {
            using (Stream fs = File.OpenWrite(UserCarparkJson))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, userCarparkList);
                }
            }
        }
    }
}
