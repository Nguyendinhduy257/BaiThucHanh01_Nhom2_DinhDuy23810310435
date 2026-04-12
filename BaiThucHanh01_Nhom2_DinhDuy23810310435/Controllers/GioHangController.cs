using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models; // Đổi lại theo tên project của sếp
using System.Linq;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Controllers
{
    public class GioHangController : Controller
    {
        // Nhúng DbContext vào đây 
        private readonly ApplicationDbContext _context;

        public GioHangController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiện giỏ hàng
        public IActionResult Index()
        {
            // Lấy danh sách giỏ hàng, DÙNG .Include ĐỂ LÔI ĐƯỢC ẢNH VÀ THÔNG TIN SẢN PHẨM RA
            var cartItems = _context.GioHangs
                                    .Include(g => g.SanPham)
                                    .ToList();
            return View(cartItems);
        }

        // Logic thêm vào giỏ
        // Sửa hàm AddToCart để nhận thêm số lượng
        public IActionResult AddToCart(int id, int soLuong = 1)
        {
            var sp = _context.SanPham.FirstOrDefault(x => x.Id == id);
            if (sp == null) return NotFound();

            var cartItem = _context.GioHangs.FirstOrDefault(g => g.SanPhamId == id);

            if (cartItem == null)
            {
                var newItem = new GioHang
                {
                    SanPhamId = id,
                    SoLuong = soLuong // Lấy đúng số lượng người dùng chọn
                };
                _context.GioHangs.Add(newItem);
            }
            else
            {
                cartItem.SoLuong += soLuong; // Cộng thêm số lượng mới vào số lượng cũ
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Thêm hàm cập nhật nhanh (dùng cho nút + - ở trang Giỏ hàng)
        public IActionResult UpdateQuantity(int id, int alignment) // alignment: 1 là tăng, -1 là giảm
        {
            var cartItem = _context.GioHangs.FirstOrDefault(g => g.Id == id);
            if (cartItem != null)
            {
                cartItem.SoLuong += alignment;
                if (cartItem.SoLuong <= 0)
                {
                    _context.GioHangs.Remove(cartItem); // Nếu giảm về 0 thì xóa luôn khỏi giỏ
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Hàm xóa sản phẩm khỏi giỏ
        public IActionResult RemoveFromCart(int id)
        {
            var item = _context.GioHangs.Find(id);
            if (item != null)
            {
                _context.GioHangs.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        // Action xử lý thanh toán
        public IActionResult ProcessPayment()
        {
            // 1. Logic lưu hóa đơn vào DB (có thể thêm bảng HoaDon ở đây sau)

            // 2. Xóa sạch giỏ hàng
            var allItems = _context.GioHangs.ToList();
            _context.GioHangs.RemoveRange(allItems);
            _context.SaveChanges();

            // 3. Trả về thông báo thành công (dùng TempData để báo cho View hiện Modal)
            TempData["PaymentSuccess"] = true;

            return RedirectToAction("Index");
        }
    }
}