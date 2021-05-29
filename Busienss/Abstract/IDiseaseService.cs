using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss
{
    public interface IDiseaseService
    {
        void Add(Disease disease);
        void Update(Disease disease); 
        void Delete(Disease disease);
        Disease Get(int diseaseId);
        List<Disease> GetAll();
    }
}
