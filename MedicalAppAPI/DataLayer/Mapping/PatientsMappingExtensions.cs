using MedicalAppAPI.DataLayer.Dtos;
using MedicalAppAPI.Entities;
using MedicalAppAPI.DataLayer.Mapping;
using System.Numerics;

namespace MedicalAppAPI.Mapping
{
    public static class PatientsMappingExtensions
    {
        public static PatientDto ToPatientDto(this Patient patient)
        {
            if (patient == null) return null;

            var result = new PatientDto();
            result.Id = patient.Id;
            result.FullName = patient.FirstName + " " + patient.LastName;
            result.CNP = patient.CNP;   
            result.PhoneNumber = patient.PhoneNumber;   
            result.Email = patient.Email;
            result.MedicalRecords = patient.MedicalRecords.ToMedicalRecordDtos();
            return result;
        }
    }
}
