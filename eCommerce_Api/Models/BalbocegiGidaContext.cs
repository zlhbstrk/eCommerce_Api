using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eCommerce_Api.Models
{
    public partial class BalBocegiGidaContext : DbContext
    {
        public BalBocegiGidaContext()
        {
        }

        public BalBocegiGidaContext(DbContextOptions<BalBocegiGidaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartDetail> CartDetail { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ImageSlider> ImageSlider { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            
                optionsBuilder.UseSqlServer(@"Server=ZLHBSTRK-PC\SQLEXPRESS;Database=BalBocegiGida;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<CartDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.RefId).HasColumnName("refId");
            });

            modelBuilder.Entity<ImageSlider>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CartId).HasColumnName("cartId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(200);

                entity.Property(e => e.IsStock)
                    .HasColumnName("isStock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.County)
                    .HasColumnName("county")
                    .HasMaxLength(100);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(200);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(100);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
