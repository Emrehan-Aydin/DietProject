using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _CityDal;
        public CityManager(ICityDal cityDal)
        {
            _CityDal = cityDal;
        }

        public void Add(City city)
        {
            _CityDal.Add(city);
        }

        public void Delete(City city)
        {
            _CityDal.Delete(city);
        }

        public City Get(int cityId)
        {
            return _CityDal.Get(city=>city.Id==cityId);
        }

        public List<City> GetAll()
        {
            return _CityDal.GetAll();
        }

        public void Update(City city)
        {
            _CityDal.Update(city);
        }
    }
}
