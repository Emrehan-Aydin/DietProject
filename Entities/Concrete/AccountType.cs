using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AccountType:IEntity
    {
        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }
    }
}
