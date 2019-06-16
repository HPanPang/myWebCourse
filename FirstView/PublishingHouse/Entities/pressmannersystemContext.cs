using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstView.Entities
{
    public partial class pressmannersystemContext : DbContext
    {
        public pressmannersystemContext()
        {
        }

        public pressmannersystemContext(DbContextOptions<pressmannersystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Bookauthor> Bookauthor { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Orderdetail> Orderdetail { get; set; }
        public virtual DbSet<Zhuye> Zhuye { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=rm-bp17ax6wwq604u2w0ro.mysql.rds.aliyuncs.com; UserId=zuoxin; Password=cyaini1314; Database=pressmannersystem");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.ToTable("administrator");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.IsContact)
                    .IsRequired()
                    .HasColumnName("isContact")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Countsale)
                    .HasColumnName("countsale")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Editor)
                    .HasColumnName("editor")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("decimal(10,0) unsigned");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasColumnName("format")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Inventory)
                    .HasColumnName("inventory")
                    .HasColumnType("decimal(65,0)");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("isbn")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PageCount)
                    .IsRequired()
                    .HasColumnName("pageCount")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PublicationDate).HasColumnName("publicationDate");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.WordCount)
                    .IsRequired()
                    .HasColumnName("wordCount")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Bookauthor>(entity =>
            {
                entity.ToTable("bookauthor");

                entity.HasIndex(e => e.Aid)
                    .HasName("aid");

                entity.HasIndex(e => e.Bid)
                    .HasName("bid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Aid)
                    .IsRequired()
                    .HasColumnName("aid")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Bid)
                    .IsRequired()
                    .HasColumnName("bid")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.A)
                    .WithMany(p => p.Bookauthor)
                    .HasForeignKey(d => d.Aid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("aid");

                entity.HasOne(d => d.B)
                    .WithMany(p => p.Bookauthor)
                    .HasForeignKey(d => d.Bid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bid");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("customers");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("int(12)");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasColumnType("char(4)")
                    .HasDefaultValueSql("'男'");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.Cid)
                    .HasName("customer_cid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cid)
                    .IsRequired()
                    .HasColumnName("cid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasColumnName("orderStatus")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.OrderTime).HasColumnName("orderTime");

                entity.Property(e => e.PayTime).HasColumnName("payTime");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("totalPrice")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("booknnn");
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.ToTable("orderdetail");

                entity.HasIndex(e => e.Oid)
                    .HasName("order_id");

                entity.HasIndex(e => e.Pid)
                    .HasName("pid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Oid)
                    .IsRequired()
                    .HasColumnName("oid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Pid)
                    .IsRequired()
                    .HasColumnName("pid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Quantity)
                    .IsRequired()
                    .HasColumnName("quantity")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.O)
                    .WithMany(p => p.Orderdetail)
                    .HasForeignKey(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("oid");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Orderdetail)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pid");
            });

            modelBuilder.Entity<Zhuye>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PRIMARY");

                entity.ToTable("zhuye");

                entity.Property(e => e.Isbn)
                    .HasColumnName("isbn")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Dierjuhua)
                    .IsRequired()
                    .HasColumnName("dierjuhua")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Jianjie)
                    .IsRequired()
                    .HasColumnName("jianjie")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Shujixiangqing)
                    .IsRequired()
                    .HasColumnName("shujixiangqing")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Shuming)
                    .IsRequired()
                    .HasColumnName("shuming")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Yijuhua)
                    .IsRequired()
                    .HasColumnName("yijuhua")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Zhuju)
                    .IsRequired()
                    .HasColumnName("zhuju")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Zuozhejianjie)
                    .IsRequired()
                    .HasColumnName("zuozhejianjie")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Zuozheming)
                    .IsRequired()
                    .HasColumnName("zuozheming")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Zuozhexiangxi)
                    .IsRequired()
                    .HasColumnName("zuozhexiangxi")
                    .HasColumnType("varchar(255)");
            });
        }
    }
}
