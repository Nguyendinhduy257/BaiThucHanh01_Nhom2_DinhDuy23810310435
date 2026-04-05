using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    [Table("SanPham")] //ten TABLE : SanPham
    public class SanPham
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập tên sản phẩm")]
        [MaxLength(255)]
        public string? TenSanPham { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập giá bán")]
        public decimal GiaBan { get; set; } // có thể thay đổi do yếu tố giảm giá
        public decimal? GiaGoc {  get; set; }

        public int? PhanTramGiam {  get; set; }

        [MaxLength(500)]
        public string? DuongDanAnh { get; set; } // VD: /lib/ao-thun.png

        //cờ flag để lọc sản phẩm hiển thị theo Tab lọc sản phẩm
        public bool IsNewProduct { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsFeatureProduct { get; set; }

        //Khóa ngoại liên kết với bảng DanhMuc
        //[Required(ErrorMessage = "Vui lòng chọn danh mục")]
        public int? DanhMucId { get; set; }

        [ForeignKey("DanhMucId")]
        public virtual DanhMuc? DanhMuc { get; set; }

        //cờ flag để upload file từ client(không lưu ảnh vào DB)
        [NotMapped]
        public IFormFile? ImageUpload {  get; set; }
        // Navigation Property: 1 Sản phẩm có thể nằm trong nhiều Chi tiết đơn hàng
        public ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
