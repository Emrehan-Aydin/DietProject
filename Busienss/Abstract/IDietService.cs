using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss
{
    public interface IDietService
    {
        void Add(Diet diet);
        void Update(Diet diet);
        void Delete(Diet diet);
        Diet Get(string dietName);
        Diet GetById(int dietId);
        List<Diet> GetAll();
    }
}
