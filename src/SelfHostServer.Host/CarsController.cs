using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public sealed class CarsController : ApiController
    {
        public IEnumerable<Car> GetAll()
        {
            return DataStore.GetCars();
        }
    }
}
