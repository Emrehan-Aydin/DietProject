using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class DietPlan : IEntity
    {
        public int Id { get; set; }
        public int DietPlanId { get; set; }
        public string? DietPlansDay { get; set; }
        public string? DietBreakFastDescription { get; set; }
        public string? DietLunchDescription { get; set; }
        public string? DietDinnerDescription { get; set; }
    }
}
