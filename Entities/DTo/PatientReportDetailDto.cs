using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTo
{
    public class PatientReportDetailDto:IDTo
    {
        public string Tc_No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirt { get; set; }
        public string Diagnosis { get; set; }
        public string Nutritionist { get; set; }
        public string DietType { get; set; }
        public string Symptom { get; set; }
    }
}
