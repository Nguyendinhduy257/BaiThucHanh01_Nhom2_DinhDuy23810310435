using BaiThucHanh01_Nhom2_DinhDuy23810310435.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiThucHanh01_Nhom2_DinhDuy23810310435.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
