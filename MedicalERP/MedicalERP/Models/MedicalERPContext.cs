using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MedicalERP.Models
{
    public partial class MedicalERPContext : DbContext
    {
        public MedicalERPContext()
        {
        }

        public MedicalERPContext(DbContextOptions<MedicalERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SpecialityMaster> SpecialityMasters { get; set; }
        public virtual DbSet<TblDoctor> TblDoctors { get; set; }
        public virtual DbSet<TblDoctorSpecialityDoctorMapping> TblDoctorSpecialityDoctorMappings { get; set; }
        public virtual DbSet<TblPatient> TblPatients { get; set; }
        public virtual DbSet<TblPatientDoctorMapping> TblPatientDoctorMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MedicalERP;Trusted_Connection=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SpecialityMaster>(entity =>
            {
                entity.ToTable("SpecialityMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Speciality).HasMaxLength(200);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDoctor>(entity =>
            {
                entity.ToTable("tblDoctor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDoctorSpecialityDoctorMapping>(entity =>
            {
                entity.ToTable("tblDoctorSpecialityDoctorMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatient>(entity =>
            {
                entity.ToTable("tblPatient");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPatientDoctorMapping>(entity =>
            {
                entity.ToTable("tblPatientDoctorMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
