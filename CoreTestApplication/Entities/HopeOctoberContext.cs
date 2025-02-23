using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoreTestApplication.Entities
{
    public partial class HopeOctoberContext : DbContext
    {
        public HopeOctoberContext()
        {
        }

        public HopeOctoberContext(DbContextOptions<HopeOctoberContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<MoneyTable> MoneyTables { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherStudent> TeacherStudents { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TalentPC002;Database=HopeOctober;Trusted_Connection=True; User Id=sa;password=P@ssw0rd;Integrated Security=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MoneyTable>(entity =>
            {
                entity.HasKey(e => e.MoneyId);

                entity.ToTable("MoneyTable");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.SellingPrice).HasColumnType("decimal(25, 3)");
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

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Students_Doctors");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherSubject)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TeacherStudent>(entity =>
            {
                entity.HasKey(e => e.StudentTeacherId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TeacherStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudents_Students");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherStudents)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherStudents_Teachers");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
