using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfPatientReportDal: EfEntityRepositoryBase<PatientReport, DietProjectContext>, IPatientReportDal
    {
        public List<PatientReportDetailDto> GetPatientDetail()
        {
            using (DietProjectContext dietProjectContext = new DietProjectContext())
            {
                var result = from P in dietProjectContext.PatientReports

                             join U in dietProjectContext.UserInformations
                             on P.PatientId equals U.Id

                             join C in dietProjectContext.Citys
                             on U.City equals C.Id

                             join Du in dietProjectContext.UserInformations
                             on P.NutritionistId equals Du.Id

                             join Dt in dietProjectContext.Diets
                             on P.DietsId equals Dt.DietId

                             join D in dietProjectContext.Diseases
                             on P.DiseaseId equals D.DiseaseId

                             select new PatientReportDetailDto
                             {
                                 Tc_No = U.Tc_No,
                                 Name = U.Name,
                                 Surname = U.Surname,
                                 Gender = U.Gender,
                                 DateOfBirt = U.DateOfBirth,
                                 City = C.CityName,
                                 Diagnosis = D.DiseaseName,
                                 DietType = Dt.DietName,
                                 Nutritionist = Du.Name + " " + Du.Surname,
                                 Symptom = P.Symptom
                             };
                return result.ToList();
            }
        }
        public PatientReportDetailDto GetByTcPatientDetail(string Tc_Number)
        {
            using (DietProjectContext dietProjectContext = new DietProjectContext())
            {
                var result = from P in dietProjectContext.PatientReports

                             join U in dietProjectContext.UserInformations
                             on P.PatientId equals U.Id

                             join C in dietProjectContext.Citys
                             on U.City equals C.Id

                             join Du in dietProjectContext.UserInformations
                             on P.NutritionistId equals Du.Id

                             join Dt in dietProjectContext.Diets
                             on P.DietsId equals Dt.DietId

                             join D in dietProjectContext.Diseases
                             on P.DiseaseId equals D.DiseaseId

                             where U.Tc_No == Tc_Number

                             select new PatientReportDetailDto
                             {
                                 Tc_No = U.Tc_No,
                                 Name = U.Name,
                                 Surname = U.Surname,
                                 Gender = U.Gender,
                                 DateOfBirt = U.DateOfBirth,
                                 City = C.CityName,
                                 Diagnosis = D.DiseaseName,
                                 DietType = Dt.DietName,
                                 Nutritionist = Du.Name + " " + Du.Surname,
                                 Symptom = P.Symptom
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
