using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss
{
    public interface IPatientReportService
    {
        void Add(PatientReport patientReport);
        void Update(PatientReport patientReport);
        void Delete(PatientReport patientReport);
        List<PatientReportDetailDto> GetPatientDetail();
        PatientReportDetailDto GetByTcPatientDetail(string Tc_Number);
        PatientReport Get(int patientId);
        List<PatientReport> GetAll();
    }
}
