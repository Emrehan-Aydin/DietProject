using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserInformationDal: IEntityRepository<UserInformation>
    {
        List<NutritionistDetailDto> GetNutritionistDetail();
    }
}
