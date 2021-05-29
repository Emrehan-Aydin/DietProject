using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Disease:IEntity
    {
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
    }
}
