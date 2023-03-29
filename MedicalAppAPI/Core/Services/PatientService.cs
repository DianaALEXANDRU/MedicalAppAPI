using MedicalAppAPI.DataLayer.Dtos;
using MedicalAppAPI.Entities;
using MedicalAppAPI.Repository;
using MedicalAppAPI.Mapping;
using System.Numerics;
using MedicalAppAPI.Core.Dtos;

namespace MedicalAppAPI.Core.Services
{
    public class PatientService
    {
        private PatientRepository patientRepository { get; set; }

        public PatientService(PatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        public List<Patient> GetAll()
        {
            var result = patientRepository.GetAlL();

            return result;
        }

        public PatientDto GetById(int patientId)
        {
            var patient = patientRepository.GetById(patientId);

            var result = patient.ToPatientDto();

            return result;
        }

        public bool CreatePatient(Patient patient)
        {
            if (patient != null)
            {
                var newPatient = patientRepository.CreatePatient(patient);
                if (newPatient == null)
                    return false;
                return true;
            }
            return false;

        }

        public bool DeletePatient(int patientId)
        {
            var patient = patientRepository.GetById(patientId);

            if (patient == null)
                return false;
            var deleted = patientRepository.DeletePatient(patient);
            if (deleted)
                return true;
            return false;
        }

        public bool EditName(PatientUpdateDto payload)
        {
            if (payload == null  || payload.FirstName == null || payload.LastName == null)
            {
                return false;
            }

            var result = patientRepository.GetById(payload.Id);
            if (result == null) return false;

            result.FirstName = payload.FirstName;
            result.LastName = payload.LastName;

            return true;
        }

    }
}
