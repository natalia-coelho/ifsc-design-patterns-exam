using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Services.External
{
    public class PatientServiceAdapter : IExternalPatientService
    {
        private readonly ThirdPartyPatientService _thirdPartyService = new ThirdPartyPatientService();

        public void GetPatientData(int patientId)
        {
            _thirdPartyService.FetchPatientData(patientId);
        }
    }
}
