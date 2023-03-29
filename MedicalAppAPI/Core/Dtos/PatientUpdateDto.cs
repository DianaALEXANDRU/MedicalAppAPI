using System.ComponentModel.DataAnnotations;

namespace MedicalAppAPI.Core.Dtos
{
    public class PatientUpdateDto
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }
       // public string CNP { get; set; }

       // public string PhoneNumber { get; set; }
        //public string Email { get; set; }

    }
}
