using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CourseDomain.Entities
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
        public virtual DbSet<Selectcourse> Selectcourse { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=rm-bp17ax6wwq604u2w0ro.mysql.rds.aliyuncs.com;UserId=root;Password=123968574qQ;Database=coursecontrol");
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
                entity.HasKey(e => new { e.CstuId, e.CcourseCode })
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

            modelBuilder.Entity<Selectcourse>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.TeacherId, e.StudentId })
                    .HasName("PRIMARY");

                entity.ToTable("selectcourse");

                entity.HasIndex(e => e.StudentId)
                    .HasName("Studentid");

                entity.HasIndex(e => e.TeacherId)
                    .HasName("Teacherid");

                entity.Property(e => e.CourseId)
                    .HasColumnName("Course_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("Teacher_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StudentId)
                    .HasColumnName("Student_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Selectcourse)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Courseid");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Selectcourse)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Studentid");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Selectcourse)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Teacherid");
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

                entity.Property(e => e.Chushengdi)
                    .HasColumnName("chushengdi")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Laiyuansheng)
                    .HasColumnName("laiyuansheng")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Mingzu)
                    .HasColumnName("mingzu")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Shengfenzheng)
                    .HasColumnName("shengfenzheng")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Shoujihaoma)
                    .HasColumnName("shoujihaoma")
                    .HasColumnType("varchar(255)");

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

                entity.Property(e => e.Xueyuan)
                    .HasColumnName("xueyuan")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Zhengzhimianmao)
                    .HasColumnName("zhengzhimianmao")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("teacher");

                entity.Property(e => e.TeacherId)
                    .HasColumnName("Teacher_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Chushengdi)
                    .HasColumnName("chushengdi")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Mingzu)
                    .HasColumnName("mingzu")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Shoujihaoma)
                    .HasColumnName("shoujihaoma")
                    .HasColumnType("varchar(255)");


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

                entity.Property(e => e.Zhengzhimianmao)
                    .HasColumnName("zhengzhimianmao")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.UpdateTime).HasColumnName("Update_Time");
            });
        }
    }
}
