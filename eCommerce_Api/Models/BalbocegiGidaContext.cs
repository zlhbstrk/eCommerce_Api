using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eCommerce_Api.Models
{
    public partial class BalbocegiGidaContext : DbContext
    {
        public BalbocegiGidaContext()
        {
        }

        public BalbocegiGidaContext(DbContextOptions<BalbocegiGidaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ZLHBSTRK-PC\\SQLEXPRESS;Database=BalbocegiGida;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(200);

                entity.Property(e => e.IsStock).HasColumnName("isStock");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
