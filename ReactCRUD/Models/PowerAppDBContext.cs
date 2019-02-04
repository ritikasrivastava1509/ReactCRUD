using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReactCRUD.Models
{
    public partial class PowerAppDBContext : DbContext
    {
        public PowerAppDBContext()
        {
        }

        public PowerAppDBContext(DbContextOptions<PowerAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=powerapp2019.database.windows.net;Database=PowerAppDB;User ID=rahulsrivastav;password=Cvjps3389e!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Price).HasMaxLength(10);

                entity.Property(e => e.ProductName).HasMaxLength(10);
            });
        }
    }
}
