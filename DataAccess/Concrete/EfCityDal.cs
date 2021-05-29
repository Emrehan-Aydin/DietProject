using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCityDal: EfEntityRepositoryBase<City, DietProjectContext>, ICityDal
    {
    }
}
