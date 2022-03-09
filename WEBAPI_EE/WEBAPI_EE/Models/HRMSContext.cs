using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WEBAPI_EE.Models
{
    public partial class HRMSContext : DbContext
    {
        public HRMSContext()
        {
        }

        public HRMSContext(DbContextOptions<HRMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BandTable> BandTables { get; set; }
        public virtual DbSet<DepartmentTable> DepartmentTables { get; set; }
        public virtual DbSet<EmployeeH> EmployeeHs { get; set; }
        public virtual DbSet<LoginTable> LoginTables { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HRMS;Trusted_Connection=True");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BandTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BandTable");

                entity.Property(e => e.BandName)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<DepartmentTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("departmentTable");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<EmployeeH>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeH");

                entity.Property(e => e.AlternativeEmailId)
                    .HasMaxLength(150)
                    .HasColumnName("AlternativeEmailID");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DateofBirth).HasColumnType("date");

                entity.Property(e => e.DateofJoining).HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(150)
                    .HasColumnName("EmailID");

                entity.Property(e => e.EmployeeBand).HasMaxLength(50);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoginTable");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.Username).HasMaxLength(90);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
