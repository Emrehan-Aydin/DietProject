using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Abstract
{
    public interface IDietDal : IEntityRepository<Diet>
    {
    }
}
