using Microsoft.AspNetCore.Mvc;
using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Controllers
{
    public class SanPhamController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ApplicationDbContext _context;
        //tiêm DBContext để giao tiếp với PostGreSQL
        public SanPhamController(ApplicationDbContext context)
        {
            _context = context;
        }
        //hiển thị giao diện View chính
        // ==========================================
        // ACTION 1: INFO - Hiển thị và Phân trang (Mỗi trang 10 SP)
        // ==========================================
        public IActionResult Info(string tab = "new", int page = 1)
        {
            int pageSize = 10; // Cứ 10 ID / sản phẩm thì cắt thành 1 trang
            var query = _context.SanPham.AsQueryable();

            // 1. Lọc dữ liệu theo Tab
            if (tab == "sale")
            {
                query = query.Where(sp => sp.IsOnSale);
            }
            else if (tab == "featured")
            {
                query = query.Where(sp => sp.IsFeatureProduct);
            }
            else
            {
                query = query.Where(sp => sp.IsNewProduct); // Mặc định là Tab New
            }

            // 2. Tính toán tổng số trang, mỗi 10 sản phẩm thì + 1 trang
            int totalItems = query.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // 3. Cắt lấy đúng 10 sản phẩm của trang hiện tại (Skip và Take)
            var dsSanPham = query.OrderBy(sp => sp.Id)
                                 .Skip((page - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToList();

            // 4. Gửi các thông số phân trang ra View qua ViewBag
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.ActiveTab = tab;

            return View(dsSanPham);
        }
        //Add cập nhật sản phẩm, thêm sản phẩm mới
        [HttpGet]
        public IActionResult Add()
        {
            return View(); //trả về giao diện form nhập liệu
        }
        [HttpPost]
        public IActionResult Add(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                _context.SanPham.Add(sanPham);
                _context.SaveChanges();//lưu vào bảng trên CSDL
                return RedirectToAction("Info");
            }
            return View();//nếu không kết nối được CSDL cần ADD -> giữ nguyên Form nhập liệu
        }
        //EDIT chinh sua thong tin
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //tìm kiếm Table SanPham trong CSDL, tiếp tục tìm kiếm và in ra sản phẩm với id cần sửa
            var sanPham = _context.SanPham.Find(id);
            if (sanPham == null) return NotFound();
            return View(sanPham); //đẩy dữ liệu cũ lên form để người dùng có thể ghi đè thanh INPUT
        }
        [HttpPost]
        public IActionResult Edit(SanPham sanPham)
        {
            //nếu tìm thấy đúng CSDL và đã sẵn sàng để kết nối thì cập nhật lên PostGreSQL
            if (ModelState.IsValid)
            {
                _context.SanPham.Update(sanPham);
                _context.SaveChanges();
                return RedirectToAction("Info");//quay lại hàm Info cũng tại file này
            }
            return View(sanPham);
        }
        [HttpGet]
        public IActionResult Edit1()
        {
            return View();
        }
    }
}
