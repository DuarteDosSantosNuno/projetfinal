using band_apa_api.Entities;
using System.Collections.Generic;

namespace band_apa_api.Repositories
{
    public interface IDemandRepository
    {
        public Demand FindById(int id);
    }
}
