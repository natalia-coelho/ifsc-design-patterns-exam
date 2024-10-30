using HospitalPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Observers
{
    public class DoctorObserver : IObserver
    {
        public void Update(Patient patient)
        {
            Console.WriteLine($"Médico notificado sobre a condição do paciente: {patient.Name}, {patient.Age} ");
        }
    }
}
