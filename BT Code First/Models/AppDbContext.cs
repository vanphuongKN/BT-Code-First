using Microsoft.EntityFrameworkCore;

namespace BT_Code_First.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Máy sẽ dựa vào đây để tạo bảng tên là "Books" trong SQL Server
        public DbSet<Book> Books { get; set; }
    }
}