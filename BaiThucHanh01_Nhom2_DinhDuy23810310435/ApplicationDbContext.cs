using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using Microsoft.EntityFrameworkCore;
namespace BaiThucHanh01_Nhom2_DinhDuy23810310435
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<SanPham> SanPham { get; set; }

        //lấy cấu trúc từ file Models/SanPhamSeeder.cs
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //gọi class Seeder nhét 100 sản phẩm lặp đi lặp lại vào bảng TABLE SanPham
            modelBuilder.Entity<SanPham>().HasData(SanPhamSeeder.TaoDuLieuMau());
        }
    }
}
