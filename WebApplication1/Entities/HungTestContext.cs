using Blazor.Shared.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class HungTestContext : DbContext
    {
        public HungTestContext()
        {
        }

        public HungTestContext(DbContextOptions<HungTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ConvertProduct> ConvertProducts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductHistory> ProductHistories { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<VRevenue> VRevenues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TEST001;Database=HungTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Japanese_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<ConvertProduct>(entity =>
            {
                entity.HasKey(e => new { e.Barcode1, e.Barcode2 })
                    .HasName("PK_Convert");

                entity.ToTable("ConvertProduct");

                entity.Property(e => e.Barcode1).HasMaxLength(16);

                entity.Property(e => e.Barcode2).HasMaxLength(16);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Contact).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => new { e.Barcode, e.Unit });

                entity.ToTable("Product");

                entity.Property(e => e.Barcode).HasMaxLength(16);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Interest).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.PriceBuy).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<ProductHistory>(entity =>
            {
                entity.ToTable("ProductHistory");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.NameNew).HasMaxLength(250);

                entity.Property(e => e.NameOld).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Contact1).HasMaxLength(250);

                entity.Property(e => e.Contact2).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Note).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.BillNumber).HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<TransactionDetail>(entity =>
            {
                entity.HasKey(e => new { e.Barcode, e.TracsactionId });

                entity.ToTable("TransactionDetail");

                entity.Property(e => e.Barcode).HasMaxLength(16);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.CreatedBy).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.UpdatedBy).HasMaxLength(256);
            });

            modelBuilder.Entity<VRevenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Revenue");

                entity.Property(e => e.CreateAt).HasMaxLength(30);

                entity.Property(e => e.DetailTotal).HasColumnType("decimal(38, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
