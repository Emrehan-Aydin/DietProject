using Busienss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busienss.Concrete
{
    public class PatientReportManager : IPatientReportService
    {
        IPatientReportDal _userReportDal;

        public PatientReportManager(IPatientReportDal userReportDal)
        {
            _userReportDal = userReportDal;
        }

        public void Add(PatientReport patientReport)
        {
            var result = _userReportDal.Get(PR => PR.PatientId == patientReport.PatientId);
            if (result != null)
            {
                patientReport.PatientId = result.PatientId;
                _userReportDal.Update(patientReport);
            }
            else
            {
                _userReportDal.Add(patientReport);
            }
        }

        public void Delete(PatientReport patientReport)
        {
            _userReportDal.Delete(patientReport);
        }

        public PatientReport Get(int PatientId)
        {
            return _userReportDal.Get(userReport => userReport.PatientId == PatientId);
        }

        public List<PatientReport> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PatientReportDetailDto> GetPatientDetail()
        {
            return _userReportDal.GetPatientDetail();

        }

        public PatientReportDetailDto GetByTcPatientDetail(string tc_number)
        {
            return _userReportDal.GetByTcPatientDetail(tc_number);
        }
        public void Update(PatientReport patientReport)
        {
            _userReportDal.Update(patientReport);
        }
    }
}
