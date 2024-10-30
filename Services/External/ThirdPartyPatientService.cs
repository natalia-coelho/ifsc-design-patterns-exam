using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Services.External
{
    public class ThirdPartyPatientService
    {
        public void FetchPatientData(int id)
        {
            Console.WriteLine($"Fetching data for patient ID: {id}");
        }
    }
}
