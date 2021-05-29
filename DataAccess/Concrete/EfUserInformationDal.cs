using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTo;

namespace DataAccess.Concrete
{
    public class EfUserInformationDal: EfEntityRepositoryBase<UserInformation, DietProjectContext>, IUserInformationDal
    {
        public List<NutritionistDetailDto> GetNutritionistDetail()
        {
            using (DietProjectContext dietProjectContext = new DietProjectContext())
            {
                var result = from U in dietProjectContext.UserInformations
                             join A in dietProjectContext.Accounts
                             on U.Id equals A.Id
                             join C in dietProjectContext.Citys
                             on U.City equals C.Id
                             where A.AccountType ==2
                             select new NutritionistDetailDto
                             {
                                Tc_No=U.Tc_No,
                                Name=U.Name,
                                Surname=U.Surname,
                                Gender = U.Gender,
                                City = C.CityName,
                                DateOfBirt = U.DateOfBirth
                             };
                return result.ToList();
            }
        }
    }
}
