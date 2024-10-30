using HospitalPrototype.Models;
using HospitalPrototype.Observers;
using HospitalPrototype.Services;
using HospitalPrototype.Services.External;

Console.WriteLine("Sistema hospitalar inciado.");

//Singleton
DatabaseConnection.InstanciarBancoDeDadosSingleton();

// Builder
var patientBuilder = new Patient.Builder()
    .SetName("Natalia Coelho Oliveira")
    .SetAge(23)
    .SetAddress("rua das margaridas")
    .SetMedicalHistory("Enxaquecas");
var patient = patientBuilder.Build();

Patient.ImprimirDadosPaciente(patient);

// Padrão Estrutural: Adapter
    // (simulando uma conexão em uma API)
var externalService = new PatientServiceAdapter();
Console.WriteLine("Buscando dados do paciente na API externa...");
externalService.GetPatientData(1);

//Padrão Comportamental: Observer
var treatmentData = new TreatmentData();

var doctorObserver = new DoctorObserver();
var familyObserver = new FamilyMemberObserver();

// registrando interessados
treatmentData.RegisterObserver(doctorObserver);
treatmentData.RegisterObserver(familyObserver);

// notificando interessados

Console.WriteLine("Atualizando o estado do paciente e notificando interessados...");
treatmentData.NotifyObservers(patient);

Console.WriteLine("Sistema Hospitalar Finalizado.");
