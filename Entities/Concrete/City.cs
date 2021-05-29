using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class City : IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
