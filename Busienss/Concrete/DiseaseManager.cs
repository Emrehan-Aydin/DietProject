using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class DiseaseManager : IDiseaseService
    {
        IDiseaseDal _diseaseDal;

        public DiseaseManager(IDiseaseDal diseaseDal)
        {
            _diseaseDal = diseaseDal;
        }

        public void Add(Disease disease)
        {
            if (disease.DiseaseId == 0)
            {
                _diseaseDal.Add(disease);
            }
            else
            {
                _diseaseDal.Update(disease);
            }
        }

        public void Delete(Disease disease)
        {
            _diseaseDal.Delete(disease);
        }

        public Disease Get(int diseaseId)
        {
            return _diseaseDal.Get(disease=>disease.DiseaseId==diseaseId);
        }

        public List<Disease> GetAll()
        {
            return _diseaseDal.GetAll();
        }

        public void Update(Disease disease)
        {
            _diseaseDal.Update(disease);
        }
    }
}
