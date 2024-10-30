using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPrototype.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string MedicalHistory { get; set; }

        private Patient() { }

        public class Builder
        {
            private readonly Patient _patient = new Patient();

            public Builder SetName(string name)
            {
                _patient.Name = name;
                return this;
            }

            public Builder SetAge(int age)
            {
                _patient.Age = age;
                return this;
            }

            public Builder SetAddress(string address)
            {
                _patient.Address = address;
                return this;
            }

            public Builder SetMedicalHistory(string medicalHistory)
            {
                _patient.MedicalHistory = medicalHistory;
                return this;
            }

            public Patient Build()
            {
                return _patient;
            }
        }

        public static void ImprimirDadosPaciente(Patient patient)
        {
            Console.WriteLine($"\nPaciente Criado: {patient.Name}, Idade: {patient.Age}, Histórico: {patient.MedicalHistory}");
        }
    }
}
