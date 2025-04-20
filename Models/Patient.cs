using System.ComponentModel.DataAnnotations;

namespace Clinic.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public int NationalID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? BloodType { get; set; }
        public string? Allergies { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Medical> MedicalRecords { get; set; }
    }
}
