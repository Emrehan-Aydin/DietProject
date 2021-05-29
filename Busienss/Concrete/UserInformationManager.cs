using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class UserInformationManager : IUserInformationService
    {
        IUserInformationDal _userInformationDal;

        public UserInformationManager(IUserInformationDal userInformationDal)
        {
            _userInformationDal = userInformationDal;
        }

        public void Add(UserInformation userInformation)
        {
            var result = _userInformationDal.Get(user=>user.Tc_No==userInformation.Tc_No);
            if (result!=null)
            {
                userInformation.Id = result.Id;
                _userInformationDal.Update(userInformation);
            }
            else
            {
                _userInformationDal.Add(userInformation);
            }
            
        }

        public void Delete(UserInformation userInformation)
        {
            _userInformationDal.Delete(userInformation);
        }

        public UserInformation Get(string userInformationId)
        {
            return _userInformationDal.Get(userInformation=>userInformation.Tc_No==userInformationId);
        }

        public List<UserInformation> GetAll()
        {
            return _userInformationDal.GetAll();
        }
        public List<NutritionistDetailDto> GetNutritionistDetail()
        {
            return _userInformationDal.GetNutritionistDetail();
        }
        public void Update(UserInformation userInformation)
        {
            _userInformationDal.Update(userInformation);
        }
    }
}
