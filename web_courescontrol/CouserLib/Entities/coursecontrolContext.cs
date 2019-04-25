using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CouserLib_DomainModel.Entities
{
    public partial class coursecontrolContext : DbContext
    {
        public coursecontrolContext()
        {
        }

        public coursecontrolContext(DbContextOptions<coursecontrolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=127.0.0.1;UserId=root;Password=123968574;Database=coursecontrol");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseCode)
                    .HasName("PRIMARY");

                entity.ToTable("course");

                entity.Property(e => e.CourseCode)
                    .HasColumnName("Course_code")
                    .HasColumnType("int(255)");

                entity.Property(e => e.CourseCredit)
                    .HasColumnName("Course_credit")
                    .HasColumnType("float(255,1)");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasColumnName("Course_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CourseType)
                    .IsRequired()
                    .HasColumnName("Course_type")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Score>(entity =>
            {
                entity.HasKey(e => new { e.CstuId, e.CcourseCode, e.CourseScore })
                    .HasName("PRIMARY");

                entity.ToTable("score");

                entity.HasIndex(e => e.CcourseCode)
                    .HasName("CCourse_code");

                entity.Property(e => e.CstuId)
                    .HasColumnName("CStu_id")
                    .HasColumnType("int(255)");

                entity.Property(e => e.CcourseCode)
                    .HasColumnName("CCourse_code")
                    .HasColumnType("int(255)");

                entity.Property(e => e.CourseScore)
                    .HasColumnName("Course_score")
                    .HasColumnType("double(255,0)");

                entity.HasOne(d => d.CcourseCodeNavigation)
                    .WithMany(p => p.Score)
                    .HasForeignKey(d => d.CcourseCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CCourse_code");

                entity.HasOne(d => d.Cstu)
                    .WithMany(p => p.Score)
                    .HasForeignKey(d => d.CstuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CStu_id");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StuId)
                    .HasName("PRIMARY");

                entity.ToTable("student");

                entity.Property(e => e.StuId)
                    .HasColumnName("Stu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("Create_Time")
                    ;

                entity.Property(e => e.StuClass)
                    .IsRequired()
                    .HasColumnName("Stu_class")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.StuCrdit)
                    .HasColumnName("Stu_crdit")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StuName)
                    .IsRequired()
                    .HasColumnName("Stu_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.StuPwd)
                    .IsRequired()
                    .HasColumnName("Stu_pwd")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'123456'");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("Update_Time")
                    ;
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teacher");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("Teacher_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatTime).HasColumnName("Creat_Time");

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasColumnName("Teacher_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TeacherPwd)
                    .IsRequired()
                    .HasColumnName("Teacher_pwd")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'123456'");

                entity.Property(e => e.UpdateTime).HasColumnName("Update_Time");
            });
        }
    }
}
