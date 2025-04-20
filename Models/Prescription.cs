using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
       
        public DateTime Date { get; set; }
        public string? DoctorName { get; set; }
        public int TotalMedicines { get; set; }
        public string? Notes { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
        [ForeignKey("Medical")]
        public int MedicalID { get; set; }
        public virtual Medical Medical { get; set; }
    }

}
