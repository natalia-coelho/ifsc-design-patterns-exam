using HospitalPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Observers
{
    public interface IObserver
    {
        void Update(Patient patient);
    }
}
