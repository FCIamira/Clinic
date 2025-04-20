using Clinic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Context
{
    public class ClinicContext:IdentityDbContext<AplicationUser>
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        { }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Medical> Medicals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public  DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionDetail> PrescriptionsDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PrescriptionDetail>()
                .HasKey(pd => new { pd.PrescriptionID, pd.MedicineID });


            modelBuilder.Entity<Patient>().Property(p => p.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Prescription>().Property(p => p.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Medical>().Property(p => p.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Medicine>().Property(p=>p.IsDeleted).HasDefaultValue(false);
            modelBuilder.Entity<Appointment>().Property(p => p.IsDeleted).HasDefaultValue(false);


        }

    }

}