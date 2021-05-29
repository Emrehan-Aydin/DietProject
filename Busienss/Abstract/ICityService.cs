using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss
{
    public interface ICityService
    {
        void Add(City city);
        void Update(City city);
        void Delete(City city);
        City Get(int cityId);
        List<City> GetAll();
    }
}
