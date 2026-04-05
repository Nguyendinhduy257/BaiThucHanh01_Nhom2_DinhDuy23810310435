using Microsoft.AspNetCore.Mvc;
using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Controllers
{
    public class DanhMucController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DanhMucController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. HIỂN THỊ DANH SÁCH DANH MỤC
        public IActionResult Index()
        {
            var dsDanhMuc = _context.DanhMucs.ToList();
            return View(dsDanhMuc);
        }

        // 2. THÊM DANH MỤC
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(DanhMuc danhMuc)
        {
            ModelState.Remove("SanPhams");
            if (ModelState.IsValid)
            {
                _context.DanhMucs.Add(danhMuc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(danhMuc);
        }

        // 3. SỬA DANH MỤC
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var danhMuc = _context.DanhMucs.Find(id);
            if (danhMuc == null) return NotFound();
            return View(danhMuc);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DanhMuc danhMuc)
        {
            ModelState.Remove("SanPhams");
            if (ModelState.IsValid)
            {
                _context.DanhMucs.Update(danhMuc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(danhMuc);
        }

        // 4. XÓA DANH MỤC
        public async Task<IActionResult> Delete(int id)
        {
            var danhMuc = await _context.DanhMucs.Include(d => d.SanPhams).FirstOrDefaultAsync(d => d.Id == id);
            if (danhMuc == null) return NotFound();

            // Kiểm tra nếu danh mục đang có sản phẩm thì không cho xóa (tránh lỗi khóa ngoại)
            if (danhMuc.SanPhams != null && danhMuc.SanPhams.Any())
            {
                TempData["ErrorMessage"] = "Không thể xóa danh mục đang chứa sản phẩm!";
                return RedirectToAction("Index");
            }

            _context.DanhMucs.Remove(danhMuc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}