using QuanLyKho.Data;
using QuanLyKho.Models;
using System.Data.Entity;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=QuanLyKhoDbContext")
    {
        Database.SetInitializer(new DbInitializer());
        this.Database.CreateIfNotExists();
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .ToTable("Categories")
            .HasKey(c => c.CategoryId);

        modelBuilder.Entity<Category>()
            .Property(c => c.TenDanhMuc)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithRequired(p => p.Category)
            .HasForeignKey(p => p.CategoryId)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Product>()
            .ToTable("Products")
            .HasKey(p => p.ProductId);

        modelBuilder.Entity<Product>()
            .Property(p => p.TenHangHoa)
            .IsRequired()
            .HasMaxLength(100);

        base.OnModelCreating(modelBuilder);
    }
}