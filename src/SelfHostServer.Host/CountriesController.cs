using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public sealed class CountriesController : ApiController
    {
        public IEnumerable<Country> GetAll()
        {
            return DataStore.GetCountries();
        }
    }
}
