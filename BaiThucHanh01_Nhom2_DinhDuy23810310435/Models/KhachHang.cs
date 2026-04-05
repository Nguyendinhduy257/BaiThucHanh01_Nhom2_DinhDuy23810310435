using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    public class KhachHang
    {
        [Key]
        public string Id { get; set; } // Thường dùng làm Tên đăng nhập

        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string HinhAnh { get; set; }
        public bool KichHoat { get; set; }

        // Navigation Property: 1 Khách hàng có nhiều Đơn hàng
        public ICollection<DonHang> DonHangs { get; set; }
    }
}