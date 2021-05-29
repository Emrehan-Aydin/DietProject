using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTo;
using Newtonsoft.Json;

namespace CreateReports.Concrete
{
    public class CreateJsonReport
    {
        string jsonString = JsonConvert.SerializeObject("Hasta Raporu");
        public void createPatientReportJson(PatientReportDetailDto Json, List<DietPlan> dietPlan)
        {
            jsonString += JsonConvert.SerializeObject(Json);
            jsonString += JsonConvert.SerializeObject("Diyet Takvimi");
            jsonString += JsonConvert.SerializeObject(dietPlan);
            File.WriteAllText(@"Report.json", jsonString);
        }
        public void createPatientReportReverseJson(PatientReportDetailDto Json, List<DietPlan> dietPlan)
        {
            ReversePatientReportDetailDto reversePatientReport = new ReversePatientReportDetailDto()
            {
                Diagnosis = Json.Diagnosis,
                City = Json.City,
                DateOfBirt = Json.DateOfBirt,
                DietType = Json.DietType,
                Gender = Json.Gender,
                Name = Json.Name,
                Nutritionist = Json.Nutritionist,
                Surname = Json.Surname,
                Symptom = Json.Symptom,
                Tc_No = Json.Tc_No
            };
            jsonString += JsonConvert.SerializeObject("Diyet Takvimi");
            jsonString += JsonConvert.SerializeObject(dietPlan);
            jsonString += JsonConvert.SerializeObject(reversePatientReport);
            File.WriteAllText(@"Report.json", jsonString);
        }

    }
}
