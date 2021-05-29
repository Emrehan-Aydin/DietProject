using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Diet:IEntity
    {
        public int DietId { get; set; }
        public string DietName { get; set; }
        public string DietDescription { get; set; }
    }
}
