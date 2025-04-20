using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Medical
    {
        public int Id { get; set; }

        public DateTime VisitDate { get; set; }
        public string? Diagnosis { get; set; }
        public string? Symptoms { get; set; }
        public string? DoctorNotes { get; set; }
        public bool FollowUpNeeded { get; set; }
        public DateTime? NextVisitDate { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }

}
