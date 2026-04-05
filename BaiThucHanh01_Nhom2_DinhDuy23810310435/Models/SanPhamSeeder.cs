using System.Collections.Generic;
using System;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    public static class DataSeeder
    {
        public static List<DanhMuc> TaoDuLieuDanhMucMau()
        {
            return new List<DanhMuc>
            {
                new DanhMuc { Id = 1, NameVN = "Áo Thời Trang", Name = "Fashion T-Shirts" },
                new DanhMuc { Id = 2, NameVN = "Quần Denim", Name = "Denim Jeans" },
                new DanhMuc { Id = 3, NameVN = "Phụ Kiện Cao Cấp", Name = "Luxury Accessories" },
                new DanhMuc { Id = 4, NameVN = "Áo Khoác Thu Đông", Name = "Winter Jackets" },
                new DanhMuc { Id = 5, NameVN = "Giày Sneaker", Name = "Sneakers" }
            };
        }

        public static List<SanPham> TaoDuLieuSanPhamMau()
        {
            var danhSach = new List<SanPham>();

            // Dùng Seed 2024 để đảm bảo "ngẫu nhiên nhưng cố định" khi Migration
            var rand = new Random(2024);

            for (int i = 1; i <= 100; i++)
            {
                // 1. Lấy ngẫu nhiên ảnh từ 1 đến 8
                int soMayMan = rand.Next(1, 9); // Next(min, max) lấy từ min đến max-1
                string anhSanPham = $"/lib/product-{soMayMan}.png";

                // 2. Tỉ lệ 10% rơi vào no-image cho thực tế
                if (rand.Next(1, 11) == 10)
                {
                    anhSanPham = "/lib/no-image.png";
                }

                danhSach.Add(new SanPham
                {
                    Id = i,
                    TenSanPham = $"Sản phẩm Trendy #{i:D3}",
                    // Giá ngẫu nhiên từ 10$ đến 200$
                    GiaBan = (decimal)(rand.Next(10, 150) + rand.NextDouble()),
                    GiaGoc = (i % 4 == 0) ? (decimal)(rand.Next(150, 250)) : null,
                    PhanTramGiam = (i % 4 == 0) ? rand.Next(5, 30) : null,
                    DuongDanAnh = anhSanPham,

                    // Trạng thái ngẫu nhiên
                    IsNewProduct = rand.Next(0, 2) == 1,
                    IsOnSale = (i % 4 == 0),
                    IsFeatureProduct = rand.Next(0, 5) == 0,

                    // Danh mục ngẫu nhiên từ 1 đến 5
                    DanhMucId = rand.Next(1, 6)
                });
            }
            return danhSach;
        }
    }
}