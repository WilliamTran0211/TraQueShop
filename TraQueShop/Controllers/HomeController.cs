using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TraQueShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TrangChu()
        {
            var danhmuc = new List<string>() {
                "Hoa Hong", "Hoa Cuoi", "Hoa Khai Truong"
            };
            ViewBag.Test = danhmuc;
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult TinTuc()
        {
            return View();
        }
    }
}