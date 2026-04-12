using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    public class GioHang
    {
        [Key]
        public int Id { get; set; }

        public int SanPhamId { get; set; }

        public int SoLuong { get; set; }

        // Khóa ngoại trỏ sang bảng SanPham để lấy Ảnh, Tên, Giá
        [ForeignKey("SanPhamId")]
        public virtual SanPham SanPham { get; set; }

        // Lưu ý: Tạm thời đang thiết kế giỏ hàng dùng chung. 
        // Nếu sau này nếu làm hệ thống Đăng nhập, nhớ thêm trường UserId vào đây để tránh "hàng của mình mà để User khác dùng"
    }
}