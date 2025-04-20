namespace Clinic.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; } // Tablet, Syrup, etc.
        public string? SideEffects { get; set; }
        public decimal? Price { get; set; }
        public int? StockQuantity { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
    }

}
