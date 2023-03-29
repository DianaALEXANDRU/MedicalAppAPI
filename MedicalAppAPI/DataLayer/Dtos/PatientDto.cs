using MedicalAppAPI.Entities;

namespace MedicalAppAPI.DataLayer.Dtos
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CNP { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<MedicalRecordDto> MedicalRecords { get; set; }
    }
}
