using System.Collections.Generic;
using System.Linq;
using band_apa_api.Data;
using band_apa_api.Entities;

namespace band_apa_api.Repositories
{
    public class DemandRepository : IDemandRepository
    {
        private ApplicationContext _applicationContext;
        public DemandRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }
        public Demand FindById(int id)
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Demands.Single(de => de.demandID == id);
        }
    }
}
