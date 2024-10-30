using HospitalPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Observers
{
    public class FamilyMemberObserver : IObserver
    {
        public void Update(Patient patient)
        {
            Console.WriteLine($"Familiar notificado sobre a condição do paciente: {patient.Name}, {patient.Age} ");
        }
    }
}
