using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class HopeRegistrationNovContext : DbContext
    {
        public HopeRegistrationNovContext()
        {
        }

        public HopeRegistrationNovContext(DbContextOptions<HopeRegistrationNovContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeesType> EmployeesTypes { get; set; }
        public virtual DbSet<GradeNumber> GradeNumbers { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<SectionNumber> SectionNumbers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherGradeNumber> TeacherGradeNumbers { get; set; }
        public virtual DbSet<TeacherStudent> TeacherStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TalentPC002;Database=HopeRegistrationNov;Trusted_Connection=True; User Id=sa;password=P@ssw0rd;Integrated Security=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_EmployeesType");
            });

            modelBuilder.Entity<EmployeesType>(entity =>
            {
                entity.HasKey(e => e.EmployeeTypeId)
                    .HasName("PK_Employees");

                entity.ToTable("EmployeesType");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GradeNumber>(entity =>
            {
                entity.ToTable("GradeNumber");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SectionNumber>(entity =>
            {
                entity.ToTable("SectionNumber");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(10);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_Students_Nationality");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(10);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TeacherGradeNumber>(entity =>
            {
                entity.HasKey(e => e.TeacherGraderNumberId);

                entity.ToTable("TeacherGradeNumber");

                entity.HasOne(d => d.GradeNumber)
                    .WithMany(p => p.TeacherGradeNumbers)
                    .HasForeignKey(d => d.GradeNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherGradeNumber_GradeNumber");

                entity.HasOne(d => d.SectionNumber)
                    .WithMany(p => p.TeacherGradeNumbers)
                    .HasForeignKey(d => d.SectionNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherGradeNumber_SectionNumber");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherGradeNumbers)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherGradeNumber_Teachers");
            });

            modelBuilder.Entity<TeacherStudent>(entity =>
            {
                entity.ToTable("TeacherStudent");

                entity.HasOne(d => d.GradeNumber)
                    .WithMany(p => p.TeacherStudents)
                    .HasForeignKey(d => d.GradeNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudent_GradeNumber");

                entity.HasOne(d => d.SectionNumber)
                    .WithMany(p => p.TeacherStudents)
                    .HasForeignKey(d => d.SectionNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudent_SectionNumber");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TeacherStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudent_Students");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
