using MedicalAppAPI.Entities;
using System.Numerics;

namespace MedicalAppAPI.Repository
{
    public class PatientRepository
    {
        public List<Patient> GetAlL()
        {
            var result = DbContext.Patients;

            return result;
        }

        public Patient GetById(int patientId)
        {
            var result = DbContext.Patients
                .Where(e => e.Id == patientId)
                .FirstOrDefault();

            return result;
        }

        public bool DeletePatient(Patient patient)
        {
            var deleted = DbContext.Patients.Remove(patient);
            if (deleted)
                return true;
            return false;
        }

        public Patient CreatePatient(Patient patient)
        {
            Random rand = new Random();
            if (patient.Id == null || patient.Id == 0)
                patient.Id = rand.Next(DbContext.Patients.Count, 100);
            if (patient.MedicalRecords == null)
                patient.MedicalRecords = new List<MedicalRecord>();

            var result = new Patient()
            {
                Id = patient.Id,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                CNP = patient.CNP,
                PhoneNumber = patient.PhoneNumber,
                Email = patient.Email,
               // MedicalRecords = patient.MedicalRecords,


            };


            DbContext.Patients.Add(result);
            return result;
        }

    }
}
