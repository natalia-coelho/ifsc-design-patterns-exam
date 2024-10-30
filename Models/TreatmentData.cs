using HospitalPrototype.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Models
{
    public class TreatmentData
    {
        private List<IObserver> _observers = new List<IObserver>();



        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer) 
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(Patient patient)
        {
            foreach (var observer in _observers)
                observer.Update(patient);
        }
    }
}
