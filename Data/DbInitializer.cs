using System.Data.Entity;

namespace QuanLyKho.Data
{
    public class DbInitializer : IDatabaseInitializer<AppDbContext>
    {
        public void InitializeDatabase(AppDbContext context)
        {
            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Categories (
                    CategoryId INTEGER PRIMARY KEY AUTOINCREMENT,
                    TenDanhMuc NVARCHAR(100) NOT NULL
                );
            ");

            context.Database.ExecuteSqlCommand(@"
                CREATE TABLE IF NOT EXISTS Products (
                    ProductId  INTEGER PRIMARY KEY AUTOINCREMENT,
                    MaHangHoa  NVARCHAR(20),
                    TenHangHoa NVARCHAR(100) NOT NULL,
                    GiaNhap    DECIMAL NOT NULL,
                    GiaBan     DECIMAL NOT NULL,
                    CategoryId INTEGER NOT NULL,
                    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
                );
            ");
        }
    }
}