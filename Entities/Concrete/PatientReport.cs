using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class PatientReport : IEntity
    {
        [Key]
        public int PatientId { get; set; }
        public int DietsId { get; set; }
        public int DiseaseId { get; set; }
        public int NutritionistId { get; set; }
        public string Symptom { get; set; }
    }
}
