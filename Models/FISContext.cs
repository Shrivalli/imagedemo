using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ImageDemo.Models;

#nullable disable

namespace ImageDemo.Models
{
    public partial class FISContext : DbContext
    {
        public FISContext()
        {
        }

        public FISContext(DbContextOptions<FISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<Dummy> Dummies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Logintbl> Logintbls { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=FIS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__dept__D877D216515A0883");

                entity.ToTable("dept");

                entity.Property(e => e.Did)
                    .ValueGeneratedNever()
                    .HasColumnName("did");

                entity.Property(e => e.Dname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dname");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.ToTable("Dummy");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__Employee__AF4CE865A9360F69");

                entity.ToTable("Employee");

                entity.Property(e => e.Empid)
                    .ValueGeneratedNever()
                    .HasColumnName("empid");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("doj");

                entity.Property(e => e.Empname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empname");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Logintbl>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("Logintbl");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__products__DD37D91A4E5ACFCA");

                entity.ToTable("products");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Pimage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pimage");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<ImageDemo.Models.Student> Student { get; set; }
    }
}
