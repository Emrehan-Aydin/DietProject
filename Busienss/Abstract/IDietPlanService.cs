using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss
{
    public interface IDietPlanService
    {
        void Add(DietPlan dietPlan);
        void Update(DietPlan dietPlan);
        void Delete(DietPlan dietPlan);
        List<DietPlan> Get(int dietPlanId);
        List<DietPlan> GetAll();
    }
}
