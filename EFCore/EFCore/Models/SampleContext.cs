using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCore.Models
{
    public partial class SampleContext : DbContext
    {
        public SampleContext()
        {
        }

        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; }
        public virtual DbSet<Employeedepartmentmapping> Employeedepartmentmappings { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student1> Student1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Sample;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("course");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("employeeName");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeTable>(entity =>
            {
                entity.ToTable("EmployeeTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeDob)
                    .HasColumnType("date")
                    .HasColumnName("EmployeeDOB");

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(204)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComputedColumnSql("([Prefix]+right('0000'+CONVERT([varchar](4),[ID]),(4)))", true);

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employeedepartmentmapping>(entity =>
            {
                entity.ToTable("employeedepartmentmapping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.ToTable("Student1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
