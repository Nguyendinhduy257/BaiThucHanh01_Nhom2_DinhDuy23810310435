using System.Collections.Generic;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    public static class SanPhamSeeder
    {
        public static List<SanPham> TaoDuLieuMau()
        {
            var danhSach = new List<SanPham>();

            // Lặp để tạo đúng 100 sản phẩm
            for (int i = 1; i <= 100; i++)
            {
                danhSach.Add(new SanPham
                {
                    Id = i, // Entity Framework yêu cầu phải có Id khi dùng HasData
                    TenSanPham = $"Sản phẩm thời trang mẫu {i}",
                    GiaBan = 50.0m + (i % 20), // Giá ngẫu nhiên lặp lại
                    GiaGoc = (i % 3 == 0) ? (70.0m + (i % 20)) : null, // Cứ 3 SP thì có 1 SP giảm giá
                    PhanTramGiam = (i % 3 == 0) ? 15 : null,
                    DuongDanAnh = $"/lib/product-{(i % 8) + 1}.png", // Trỏ đến các ảnh từ 1 đến 4 trong wwwroot/lib/
                    //tên ảnh đặt chính xác là: product-1.png || product-2.png ||...
                    IsNewProduct = (i % 2 == 0),
                    IsOnSale = (i % 3 == 0),
                    IsFeatureProduct = (i % 5 == 0)
                });
            }
            return danhSach;
        }
    }
}