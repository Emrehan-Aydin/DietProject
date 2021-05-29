using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class AccountTypeManager : IAccountTypeService
    {
        IAccountTypeDal _accountTypeDal;
        public AccountTypeManager(IAccountTypeDal accountTypeDal)
        {
            _accountTypeDal = accountTypeDal;
        }

        public void Add(AccountType accountType)
        {
            _accountTypeDal.Add(accountType);
        }

        public void Delete(AccountType accountType)
        {
            _accountTypeDal.Delete(accountType);
        }

        public AccountType Get(int AccountTypeId)
        {
            return _accountTypeDal.Get(accountType => accountType.AccountTypeId == AccountTypeId);
        }

        public List<AccountType> GetAll()
        {
            return _accountTypeDal.GetAll();
        }

        public void Update(AccountType accountType)
        {
            _accountTypeDal.Delete(accountType);
        }
    }
}
