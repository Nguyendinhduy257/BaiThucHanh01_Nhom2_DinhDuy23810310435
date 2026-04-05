using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int Id { get; set; }

        public int DonHangId { get; set; }
        public int SanPhamId { get; set; } // Trỏ về bảng SanPham của sếp

        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        // Navigation Properties
        [ForeignKey("DonHangId")]
        public DonHang DonHang { get; set; }

        [ForeignKey("SanPhamId")]
        public SanPham SanPham { get; set; }
    }
}