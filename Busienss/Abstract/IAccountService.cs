using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Abstract
{
    public interface IAccountService
    {
        void Add(Account account);
        void Update(Account account);
        void Delete(Account account);
        Account Get(int AccountId);
        Account Check(string accountName, string accountPassowrd);
        List<Account> GetAll();

    }
}
