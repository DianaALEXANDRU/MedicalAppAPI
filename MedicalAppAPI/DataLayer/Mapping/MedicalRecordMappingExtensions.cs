using MedicalAppAPI.DataLayer.Dtos;
using MedicalAppAPI.Entities;

namespace MedicalAppAPI.DataLayer.Mapping
{
    public static class MedicalRecordMappingExtensions
    {
        public static List<MedicalRecordDto> ToMedicalRecordDtos(this List<MedicalRecord> medicalRecords)
        {
            var results = medicalRecords.Select(e => e.ToMedicalRecordDto()).ToList();
            return results;
        }

        public static MedicalRecordDto ToMedicalRecordDto(this MedicalRecord medicalRecord)
        {
            if (medicalRecord== null) return null;

            var result = new MedicalRecordDto();
            result.Date = medicalRecord.Date;
            result.Problem = medicalRecord.Problem;

            return result;
        }
    }
}
