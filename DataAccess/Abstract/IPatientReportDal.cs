using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPatientReportDal: IEntityRepository<PatientReport>
    {
        List<PatientReportDetailDto> GetPatientDetail();
        PatientReportDetailDto GetByTcPatientDetail(string Tc_Number);

    }
}
