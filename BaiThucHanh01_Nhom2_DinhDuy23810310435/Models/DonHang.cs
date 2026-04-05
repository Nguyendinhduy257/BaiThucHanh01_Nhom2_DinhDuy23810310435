using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    public class DonHang
    {
        [Key]
        public int Id { get; set; }

        public string KhachHangId { get; set; }
        public DateTime NgayDatHang { get; set; }
        public string DiaChi { get; set; }
        public double TongTien { get; set; }
        public string MoTa { get; set; }

        // Navigation Properties
        [ForeignKey("KhachHangId")]
        public KhachHang KhachHang { get; set; }

        // 1 Đơn hàng có nhiều Chi tiết đơn hàng
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}