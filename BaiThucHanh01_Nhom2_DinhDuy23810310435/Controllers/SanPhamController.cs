using Microsoft.AspNetCore.Mvc;
using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SanPhamController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // ACTION INFO: HIỂN THỊ, LỌC VÀ PHÂN TRANG
        public IActionResult Info(string tab = "new", int page = 1, string searchName = "", int? danhMucId = null)
        {
            int pageSize = 10;
            var query = _context.SanPham.Include(sp => sp.DanhMuc).AsQueryable();

            // 1. Lọc theo Tab 
            if (tab == "sale") query = query.Where(sp => sp.IsOnSale);
            else if (tab == "featured") query = query.Where(sp => sp.IsFeatureProduct);
            else query = query.Where(sp => sp.IsNewProduct);

            // 2. Lọc theo Tên sản phẩm
            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(sp => sp.TenSanPham.ToLower().Contains(searchName.ToLower()));
            }

            // 3. Lọc theo Danh mục
            if (danhMucId.HasValue && danhMucId > 0)
            {
                query = query.Where(sp => sp.DanhMucId == danhMucId);
            }

            // Tính toán phân trang
            int totalItems = query.Count();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            var dsSanPham = query.OrderBy(sp => sp.Id)
                                 .Skip((page - 1) * pageSize)
                                 .Take(pageSize)
                                 .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.ActiveTab = tab;
            ViewBag.SearchName = searchName;
            ViewBag.CurrentDanhMuc = danhMucId;
            ViewBag.DanhMucs = _context.DanhMucs.ToList();

            // Đếm tổng số lượng sản phẩm trong giỏ hàng để hiện lên Badge
            ViewBag.TotalCartItems = _context.GioHangs.Sum(g => g.SoLuong);

            return View(dsSanPham);
        }

        // ACTION ADD: THÊM SẢN PHẨM
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.DanhMucs = new SelectList(_context.DanhMucs, "Id", "NameVN");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(SanPham sanPham, IFormFile hinhAnh)
        {
            ModelState.Remove("DanhMuc");
            ModelState.Remove("ChiTietDonHangs");
            ModelState.Remove("DuongDanAnh");
            ModelState.Remove("hinhAnh"); // <--- THÊM DÒNG NÀY VÀO ĐÂY ĐỂ NÓ KHÔNG ĐÒI ÉP UPLOAD FILE NỮA

            if (ModelState.IsValid)
            {
                // ƯU TIÊN 1: Upload file
                if (hinhAnh != null && hinhAnh.Length > 0)
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(hinhAnh.FileName);
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "images", "products");
                    Directory.CreateDirectory(uploadsFolder);
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(fileStream);
                    }
                    sanPham.DuongDanAnh = "/images/products/" + uniqueFileName;
                }
                // ƯU TIÊN 2: Nhập link thủ công hoặc bỏ trống
                else if (string.IsNullOrEmpty(sanPham.DuongDanAnh))
                {
                    sanPham.DuongDanAnh = "/lib/no-image.png";
                }

                _context.SanPham.Add(sanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction("Info");
            }

            ViewBag.DanhMucs = new SelectList(_context.DanhMucs, "Id", "NameVN", sanPham.DanhMucId);
            return View(sanPham);
        }

        // ACTION EDIT: SỬA SẢN PHẨM 
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sanPham = _context.SanPham.Find(id);
            if (sanPham == null) return NotFound();

            ViewBag.DanhMucs = new SelectList(_context.DanhMucs, "Id", "NameVN", sanPham.DanhMucId);
            return View(sanPham);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SanPham sanPham, IFormFile hinhAnh)
        {
            ModelState.Remove("DanhMuc");
            ModelState.Remove("ChiTietDonHangs");
            ModelState.Remove("DuongDanAnh");
            ModelState.Remove("hinhAnh");

            if (ModelState.IsValid)
            {
                var spCu = _context.SanPham.AsNoTracking().FirstOrDefault(x => x.Id == sanPham.Id);

                // ƯU TIÊN 1: Upload file ảnh mới
                if (hinhAnh != null && hinhAnh.Length > 0)
                {
                    // Xóa ảnh cũ nếu là ảnh tự up
                    if (!string.IsNullOrEmpty(spCu.DuongDanAnh) && spCu.DuongDanAnh.Contains("/images/products/"))
                    {
                        var oldImagePath = Path.Combine(_env.WebRootPath, spCu.DuongDanAnh.TrimStart('/'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    // Lưu ảnh mới
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(hinhAnh.FileName);
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "images", "products");
                    Directory.CreateDirectory(uploadsFolder);
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(fileStream);
                    }
                    sanPham.DuongDanAnh = "/images/products/" + uniqueFileName;
                }
                // ƯU TIÊN 2: Không up ảnh
                else if (string.IsNullOrEmpty(sanPham.DuongDanAnh))
                {
                    sanPham.DuongDanAnh = spCu.DuongDanAnh;
                }

                _context.SanPham.Update(sanPham);
                await _context.SaveChangesAsync();
                return RedirectToAction("Info");
            }

            ViewBag.DanhMucs = new SelectList(_context.DanhMucs, "Id", "NameVN", sanPham.DanhMucId);
            return View(sanPham);
        }

        // ACTION DELETE: XÓA SẢN PHẨM 
        public async Task<IActionResult> Delete(int id)
        {
            var sanPham = await _context.SanPham.FindAsync(id);
            if (sanPham == null) return NotFound();

            if (!string.IsNullOrEmpty(sanPham.DuongDanAnh) && sanPham.DuongDanAnh.Contains("/images/products/"))
            {
                var imagePath = Path.Combine(_env.WebRootPath, sanPham.DuongDanAnh.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            _context.SanPham.Remove(sanPham);
            await _context.SaveChangesAsync();
            return RedirectToAction("Info");
        }
        //ACTION xem chi tiết sản phẩm khi click vào ảnh trong thẻ sản phẩm
        public IActionResult Details(int id)
        {
            // Tìm sản phẩm theo id (sếp chỉnh lại _context tùy theo tên biến DB của sếp nhé)
            // Bao gồm cả DanhMuc để hiển thị tên danh mục ở trang chi tiết
            var sanPham = _context.SanPham
                                  .FirstOrDefault(sp => sp.Id == id);

            if (sanPham == null)
            {
                return NotFound(); // Nếu không tìm thấy trả về lỗi 404 chuẩn
            }

            // Trả về file Views/SanPham/Details.cshtml
            return View(sanPham);
        }
    }
}