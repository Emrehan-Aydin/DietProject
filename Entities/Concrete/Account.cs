﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    
    public class Account : IEntity
    {
        
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string  AccountPassword { get; set; }
        public int AccountType { get; set; }

    }
}
