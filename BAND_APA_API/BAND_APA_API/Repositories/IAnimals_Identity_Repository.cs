using System;
using BAND_APA_API.Entities;
using System.Collections.Generic;

namespace BAND_APA_API.Repositories
{
    public interface IAnimals_Identity_Repository
    {
        public List<Animals_Identity> FindAll();
    }
}
