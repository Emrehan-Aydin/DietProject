using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Abstract
{
    public interface IAccountTypeService
    {
        void Add(AccountType accountType);
        void Update(AccountType accountType);
        void Delete(AccountType accountType);
        AccountType Get(int AccountId);
        List<AccountType> GetAll();
    }
}
