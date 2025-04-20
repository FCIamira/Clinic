using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; } 
        public string? Status { get; set; } // Scheduled, Completed, Cancelled
        public string? VisitReason { get; set; }
        public string? DoctorName { get; set; }
        public string? Notes { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public virtual Patient Patient { get; set; }

    }

}
