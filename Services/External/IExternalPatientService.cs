using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Services.External
{
    public interface IExternalPatientService
    {
        void GetPatientData(int patientId);
    }
}
