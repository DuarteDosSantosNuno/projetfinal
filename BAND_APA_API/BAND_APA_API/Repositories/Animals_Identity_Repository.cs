using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BAND_APA_API.Data;
using BAND_APA_API.Entities;

namespace BAND_APA_API.Repositories
{
    public class Animals_Identity_Repository : IAnimals_Identity_Repository
    {
        private ApplicationContext _applicationContext;
        public Animals_Identity_Repository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;

        }
       
        public List<Animals_Identity> FindAll()
        {
            //_logger.LogInformation("Info : test");
            return _applicationContext.Animals_Identitys.ToList();
        }
    }
}
