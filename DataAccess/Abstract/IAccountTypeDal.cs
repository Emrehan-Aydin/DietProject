using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAccountTypeDal : IEntityRepository<AccountType>
    {
    }
}
