using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;
        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public void Add(Account account)
        {
            Account result = _accountDal.Get(accounts => accounts.AccountName == account.AccountName);
            if (result != null)
            {
                account.Id = result.Id;
                _accountDal.Update(account);
            }
            else
            {
                _accountDal.Add(account);
            }
            
        }

        public Account Check(string accountName, string accountPassowrd)
        {
            Account result = _accountDal.Get(account => account.AccountName == accountName && account.AccountPassword == accountPassowrd);
            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public void Delete(Account account)
        {
            _accountDal.Delete(account);
        }

        public Account Get(int AccountId)
        {
            return _accountDal.Get(account=>account.Id==AccountId);
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }

        public void Update(Account account)
        {
            _accountDal.Update(account);
        }
    }
}
