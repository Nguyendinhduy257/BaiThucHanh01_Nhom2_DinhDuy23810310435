using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;        
namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Models
{
    [Table("DanhMuc")]
    public class DanhMuc
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục")]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string NameVN { get; set; }

        //Mối quan hệ 1-n với sản phẩm: 1 danh mục có thể có nhiều sản phẩm, nhưng 1 sản phẩm chỉ thuộc 1 danh mục
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
