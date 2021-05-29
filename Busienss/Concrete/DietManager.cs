using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class DietManager : IDietService
    {
        IDietDal _dietDal;

        public DietManager(IDietDal dietDal)
        {
            _dietDal = dietDal;
        }

        public void Add(Diet diet)
        {
            var result = _dietDal.Get(d => d.DietName == diet.DietName);
            if ( result != null)
            {
                diet.DietId = result.DietId;
                _dietDal.Update(diet);
            }
            else
            {
                _dietDal.Add(diet);
            }
        }

        public void Delete(Diet diet)
        {
            _dietDal.Delete(diet);
        }

        public Diet Get(string dietName)
        {
            return _dietDal.Get(diet => diet.DietName == dietName);
        }

        public List<Diet> GetAll()
        {
            return _dietDal.GetAll();
        }

        public Diet GetById(int dietId)
        {
            return _dietDal.Get(diet => diet.DietId == dietId);
        }

        public void Update(Diet diet)
        {
            _dietDal.Update(diet);
        }
    }
}
