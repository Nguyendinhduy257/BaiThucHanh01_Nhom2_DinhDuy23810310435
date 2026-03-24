using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    [Table("SanPham")] //ten TABLE : SanPham
    public class SanPham
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập tên sản phẩm")]
        [MaxLength(255)]
        public string TenSanPham { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập giá bán")]
        public decimal GiaBan { get; set; } // có thể thay đổi do yếu tố giảm giá
        public decimal? GiaGoc {  get; set; }

        public int? PhanTramGiam {  get; set; }

        [MaxLength(500)]
        public string DuongDanAnh { get; set; } // VD: /lib/ao-thun.png

        //cờ flag để lọc sản phẩm hiển thị theo Tab lọc sản phẩm
        public bool IsNewProduct { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsFeatureProduct { get; set; }
    }
}
