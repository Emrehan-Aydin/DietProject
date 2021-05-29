using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTo
{
    public class NutritionistDetailDto : IDTo
    {
        public string Tc_No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirt { get; set; }
    }
}
