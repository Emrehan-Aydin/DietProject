using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    
    public class DietPlanManager : IDietPlanService
    {
        IDietPlanDal _dietPlan;

        public DietPlanManager(IDietPlanDal dietPlan)
        {
            _dietPlan = dietPlan;
        }

        public void Add(DietPlan dietPlan)
        {
            var result = _dietPlan.Get(Dp => Dp.DietPlanId == dietPlan.DietPlanId && Dp.DietPlansDay == dietPlan.DietPlansDay);
            if (result != null)
            {
                dietPlan.Id = result.Id;
                _dietPlan.Update(dietPlan);
            }
            else
            {
                _dietPlan.Add(dietPlan);
            }
        }

        public void Delete(DietPlan dietPlan)
        {
            _dietPlan.Delete(dietPlan);
        }

        public List<DietPlan> Get(int dietPlanId)
        {
            return _dietPlan.GetAll(dietPlan=>dietPlan.DietPlanId==dietPlanId);
        }

        public List<DietPlan> GetAll()
        {
            return _dietPlan.GetAll();
        }

        public void Update(DietPlan dietPlan)
        {
            _dietPlan.Update(dietPlan);
        }
    }
}
