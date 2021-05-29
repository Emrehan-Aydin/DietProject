using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss
{
    public interface IUserInformationService
    {
        void Add(UserInformation userInformation);
        void Update(UserInformation userInformation);
        void Delete(UserInformation userInformation);
        UserInformation Get(string userInformationId);
        List<NutritionistDetailDto> GetNutritionistDetail();
        List<UserInformation> GetAll();
    }
}
