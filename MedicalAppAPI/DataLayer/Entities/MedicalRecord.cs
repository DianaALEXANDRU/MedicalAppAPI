namespace MedicalAppAPI.Entities
{
    public class MedicalRecord
    {
        public int Id { get; set; }

        public string Date { get; set; }
        public string Problem { get; set; }

        public int PatientId { get; set; }
    }
}
