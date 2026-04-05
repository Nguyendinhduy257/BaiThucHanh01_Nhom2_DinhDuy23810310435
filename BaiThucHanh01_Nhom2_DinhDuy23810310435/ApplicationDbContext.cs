using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using Microsoft.EntityFrameworkCore;
namespace BaiThucHanh01_Nhom2_DinhDuy23810310435
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

        //lấy cấu trúc từ file Models/SanPhamSeeder.cs
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DanhMuc>().HasData(DataSeeder.TaoDuLieuDanhMucMau());
            modelBuilder.Entity<SanPham>().HasData(DataSeeder.TaoDuLieuSanPhamMau());
        }
    }
}
