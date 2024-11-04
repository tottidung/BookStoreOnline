﻿using System.Linq;
using System.Web.Mvc;
using BookStoreOnline.Models;

namespace BookStoreOnline.Controllers
{
    public class GioiThieuController : Controller
    {
        private NhaSachEntities db = new NhaSachEntities();

        // GET: GioiThieu
        public ActionResult Index()
        {
            var topBooks = db.SANPHAMs.OrderByDescending(s => s.SoLuongBan).Take(5).ToList(); // Lấy 5 cuốn sách bán chạy nhất
            return View(topBooks);
        }
    }
}
