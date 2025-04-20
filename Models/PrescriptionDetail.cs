using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class PrescriptionDetail
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Prescription")]
        public int PrescriptionID { get; set; }
        public virtual Prescription Prescription { get; set; }
        [ForeignKey("Medicine")]
        public int MedicineID { get; set; }
        public virtual Medicine Medicine { get; set; }

        public string Dosage { get; set; } // "الجرعه"
        public int FrequencyPerDay { get; set; }
        public int DurationInDays { get; set; }
        public string? BeforeOrAfterMeal { get; set; }
        public string? Instructions { get; set; }
    }

}
